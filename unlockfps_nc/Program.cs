using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;
using unlockfps_nc.Service;
using unlockfps_nc.Utility;

namespace unlockfps_nc
{
    internal static class Program
    {
        private static IntPtr MutexHandle = IntPtr.Zero;
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            if (File.Exists("YuanShen.exe") || File.Exists("GenshinImpact.exe"))
            {
                MessageBox.Show(@"不要将解锁器放在游戏文件夹中", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MutexHandle = Native.CreateMutex(IntPtr.Zero, true, @"GenshinFPSUnlocker");
            if (Marshal.GetLastWin32Error() == 183)
            {
                MessageBox.Show(@"另一个解锁器已在运行", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var services = new ServiceCollection();
            services.AddTransient<MainForm>();
            services.AddTransient<SettingsForm>();
            services.AddTransient<SetupForm>();
            services.AddSingleton<ConfigService>();
            services.AddSingleton<ProcessService>();
            services.AddSingleton<IpcService>();

            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }


    }
}