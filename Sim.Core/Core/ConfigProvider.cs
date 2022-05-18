using System.Configuration;

namespace Sim.Core;

public class ConfigProvider
    : IConfigProvider
{
    public void ReadAllSettings()
    {
        try
        {
            var appSettings = ConfigurationManager.AppSettings;

            if (appSettings.Count == 0)
            {
                Console.WriteLine("AppSettings is empty.");
            }
            else
            {
                foreach (var key in appSettings.AllKeys)
                {
                    Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                }
            }
        }
        catch (ConfigurationErrorsException)
        {
            Console.WriteLine("Error reading app settings");
        }
    }

    public string ReadSetting(string key)
    {
        try
        {
            var appSettings = ConfigurationManager.AppSettings;
            var result = appSettings[key] ?? "Not Found";
            Console.WriteLine(result);
            return result;
        }
        catch (ConfigurationErrorsException)
        {
            Console.WriteLine("Error reading app settings");
            return string.Empty;
        }
        catch (Exception)
        {
            return string.Empty;
        }
    }

    public void AddUpdateAppSettings(string key, string value)
    {
        try
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
        catch (ConfigurationErrorsException)
        {
            Console.WriteLine("Error writing app settings");
        }
    }
}