using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;
using unlockfps.Model;
using unlockfps.Utility;

namespace unlockfps.Service
{
    public class ProcessService
    {
        private readonly CancellationTokenSource _cts = new();
        private IntPtr _gameHandle = IntPtr.Zero;
        private int _gamePid = 0;

        private readonly Config _config;

        private readonly IpcService _ipcService;

        public ProcessService(ConfigService configService, IpcService ipcService)
        {
            _config = configService.Config;
            _ipcService = ipcService;

            _ = Task.Run(UnlockerPoll, _cts.Token);
        }

        public bool StartGame()
        {
            if (!File.Exists(_config.GamePath))
            {
                MessageBox.Show(@"游戏路径无效。", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (IsGameRunning())
            {
                MessageBox.Show(@"已有游戏实例在运行。", @"错误", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (_gameHandle != IntPtr.Zero)
            {
                Native.CloseHandle(_gameHandle);
                _gameHandle = IntPtr.Zero;
            }

            if (_config.UseHDR)
            {
                var subKeyName = Path.GetFileName(_config.GamePath) == "YuanShen.exe" ? "原神" : "Genshin Impact";
                try
                {
                    using var key = Registry.CurrentUser.CreateSubKey($@"Software\miHoYo\{subKeyName}");
                    key.SetValue("WINDOWS_HDR_ON_h3132281285", 1);
                }
                catch (Exception e)
                {
                    MessageBox.Show($@"无法启用 HDR: {e.Message}", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            STARTUPINFO si = new();
            uint creationFlag = _config.SuspendLoad ? 4u : 0u;
            var gameFolder = Path.GetDirectoryName(_config.GamePath);

            if (!Native.CreateProcess(_config.GamePath, BuildCommandLine(), IntPtr.Zero, IntPtr.Zero, false, creationFlag, IntPtr.Zero, gameFolder, ref si, out var pi))
            {
                MessageBox.Show(
                    $@"CreateProcess 失败（{Marshal.GetLastWin32Error()}）{Environment.NewLine} {Marshal.GetLastPInvokeErrorMessage()}",
                    @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ProcessUtils.InjectDlls(pi.hProcess, _config.DllList))
            {
                MessageBox.Show(
                    $@"DLL 注入失败（{Marshal.GetLastWin32Error()}）{Environment.NewLine} {Marshal.GetLastPInvokeErrorMessage()}",
                    @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_config.SuspendLoad)
                Native.ResumeThread(pi.hThread);

            _gamePid = pi.dwProcessId;
            _gameHandle = pi.hProcess;

            Native.CloseHandle(pi.hThread);
            return true;
        }

        public void OnFormClosing()
        {
            _cts.Cancel();
            Native.CloseHandle(_gameHandle);
        }

        private bool IsGameRunning()
        {
            if (_gameHandle == IntPtr.Zero)
                return false;

            if (!Native.GetExitCodeProcess(_gameHandle, out var exitCode))
                return false;

            return exitCode == 259; // STILL_ACTIVE
        }

        private async Task UnlockerPoll()
        {
            while (!_cts.IsCancellationRequested)
            {

                await Task.Delay(1000, _cts.Token);
                using var process = Process.GetProcesses()
                    .FirstOrDefault(x => x is { ProcessName: "GenshinImpact" } or { ProcessName: "YuanShen" });
                if (process == null)
                    continue;

                while (!ProcessUtils.IsWindowDrawing(process.MainWindowHandle) && !_cts.IsCancellationRequested)
                    await Task.Delay(1000, _cts.Token);

                if (!_ipcService.Start(process.Id))
                    return;

                while (!process.HasExited && !_cts.IsCancellationRequested)
                {
                    _ipcService.Update();
                    await Task.Delay(62, _cts.Token);
                }

                if (_gameHandle != IntPtr.Zero && _config.AutoClose)
                {
                    Application.Exit();
                }

                _ipcService.OnGameExit();
                await Task.Delay(5000, _cts.Token);
            }
        }

        private string BuildCommandLine()
        {
            string commandLine = $"{_config.GamePath} ";
            if (_config.PopupWindow)
                commandLine += "-popupwindow ";

            if (_config.UseCustomRes)
                commandLine += $"-screen-width {_config.CustomResX} -screen-height {_config.CustomResY} ";

            commandLine += $"-screen-fullscreen {(_config.Fullscreen ? 1 : 0)} ";
            if (_config.Fullscreen)
                commandLine += $"-window-mode {(_config.IsExclusiveFullscreen ? "exclusive" : "borderless")} ";

            if (_config.UseMobileUI)
                commandLine += "use_mobile_platform -is_cloud 1 -platform_type CLOUD_THIRD_PARTY_MOBILE ";

            commandLine += $"-monitor {_config.MonitorNum} ";
            commandLine += $"{_config.AdditionalCommandLine} ";
            return commandLine;
        }

    }
}
