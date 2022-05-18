namespace Sim.Core;

public interface IConfigProvider
{
    void AddUpdateAppSettings(string key, string value);

    void ReadAllSettings();

    string ReadSetting(string key);
}