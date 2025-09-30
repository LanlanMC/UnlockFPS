using System.IO.MemoryMappedFiles;
using System.Reflection;
using System.Runtime.InteropServices;
using unlockfps.Utility;

namespace unlockfps.Service
{
    public enum IpcStatus
    {
        None = 0,
        Error,
        Ready
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct IpcData
    {
        public IpcStatus Status;
        public int Framerate;
        public bool PowerSave;
    }

    public class IpcService(ConfigService configService) : IDisposable
    {
        private MemoryMappedFile? _sharedMemory = null;
        private MemoryMappedViewAccessor? _sharedMemoryAccessor = null;
        private string _stubPath = string.Empty;
        private ModuleGuard _stubModule = IntPtr.Zero;
        private IntPtr _wndHook = IntPtr.Zero;

        public bool Start(int processId)
        {
            _sharedMemory ??= MemoryMappedFile.CreateOrOpen(@"Global\2DE95FDC-6AB7-4593-BFE6-760DD4AB422B", 4096, MemoryMappedFileAccess.ReadWrite);
            _sharedMemoryAccessor ??= _sharedMemory.CreateViewAccessor();
            if (_sharedMemoryAccessor == null)
            {
                MessageBox.Show(@"无法创建共享内存", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Update();

            _sharedMemoryAccessor.Read(0, out IpcData ipcData);
            if (ipcData.Status == IpcStatus.Ready)
                return true;
            if (ipcData.Status == IpcStatus.Error)
                return false;

            _stubPath = GetUnlockerStubPath();
            _stubModule = Native.LoadLibrary(_stubPath);
            if (_stubModule == IntPtr.Zero)
            {
                string errorMessage = $@"无法加载桩模块: {Marshal.GetLastWin32Error()}{Environment.NewLine}{Marshal.GetLastPInvokeErrorMessage()}";
                MessageBox.Show(errorMessage, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var stubWndProc = Native.GetProcAddress(_stubModule, "WndProc");
            var targetWindow = ProcessUtils.GetWindowFromProcessId(processId);
            var threadId = Native.GetWindowThreadProcessId(targetWindow, out uint _);

            _wndHook = Native.SetWindowsHookEx(3, stubWndProc, _stubModule, threadId);
            if (_wndHook == IntPtr.Zero)
            {
                string errorMessage = $@"无法设置窗口钩子：{Marshal.GetLastWin32Error()}{Environment.NewLine}{Marshal.GetLastPInvokeErrorMessage()}";
                MessageBox.Show(errorMessage, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Native.PostThreadMessage(threadId, 0, IntPtr.Zero, IntPtr.Zero))
            {
                string errorMessage = $@"无法发布线程信息：{Marshal.GetLastWin32Error()}{Environment.NewLine}{Marshal.GetLastPInvokeErrorMessage()}";
                MessageBox.Show(errorMessage, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int retryCount = 0;
            while (true)
            {
                _sharedMemoryAccessor.Read(0, out ipcData);

                if (ipcData.Status == IpcStatus.Ready)
                    break;

                if (ipcData.Status == IpcStatus.Error)
                    return false;

                if (retryCount >= 10)
                {
                    MessageBox.Show(@"无法启动解锁器", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                retryCount++;
                Task.Delay(1000).Wait();
            }

            return true;
        }

        public void OnGameExit()
        {
            var ipcData = new IpcData
            {
                Status = IpcStatus.None,
            };

            _sharedMemoryAccessor?.Write(0, ref ipcData);
        }

        public void Update()
        {
            var ipcData = new IpcData
            {
                Framerate = configService.Config.FPSTarget,
                PowerSave = configService.Config.UsePowerSave
            };

            _sharedMemoryAccessor?.Write(0, ref ipcData);
        }

        private string GetUnlockerStubPath()
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream("unlockfps_nc.Resources.UnlockerStub.dll");

            var filePath = Path.Combine(AppContext.BaseDirectory, "UnlockerStub.dll");

            try
            {
                using var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                stream.CopyTo(fileStream);
            }
            catch (Exception) { }

            return filePath;
        }

        public void Dispose()
        {
            _sharedMemoryAccessor?.Dispose();
            _sharedMemory?.Dispose();
            _stubModule.Dispose();
        }
    }
}
