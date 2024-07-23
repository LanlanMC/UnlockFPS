using Newtonsoft.Json;
using unlockfps_nc.Model;

namespace unlockfps_nc.Service
{
    public class ConfigService
    {
        private const string ConfigName = "fps_config.json";

        public Config Config { get; private set; } = new();

        public ConfigService()
        {
            Load();
            Sanitize();
        }

        private void Load()
        {
            if (!File.Exists(ConfigName))
                return;

            try
            {
                var json = File.ReadAllText(ConfigName);
                Config = JsonConvert.DeserializeObject<Config>(json);
            }
            catch (Exception)
            {
                MessageBox.Show(@$"无法加载配置文件。{Environment.NewLine}配置文件的格式不正确，它将重置为默认值。", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Config = new();
            }
        }

        private void Sanitize()
        {
            Config.FPSTarget = Math.Clamp(Config.FPSTarget, 1, 420);
            Config.Priority = Math.Clamp(Config.Priority, 0, 5);
            Config.CustomResX = Math.Clamp(Config.CustomResX, 200, 7680);
            Config.CustomResY = Math.Clamp(Config.CustomResY, 200, 4320);
            Config.MonitorNum = Math.Clamp(Config.MonitorNum, 1, 100);
        }

        public void Save()
        {
            var json = JsonConvert.SerializeObject(Config, Formatting.Indented);
            File.WriteAllText(ConfigName, json);
        }
    }
}
