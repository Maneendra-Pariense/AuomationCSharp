using Microsoft.Extensions.Configuration;

namespace Framework.Helpers
{
    public class ConfigHelper
    {
        public ConfigSetting _setting;
        static string _settingsPath = Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + "configSettings.json";

        public ConfigHelper()
        {
            _setting = new ConfigSetting();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(_settingsPath, false, true);
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(_setting);

        }

        public string EnvironmentKey() { return _setting.EnvironmentKey; }

    }
}