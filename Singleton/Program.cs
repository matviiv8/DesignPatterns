using Singleton;

class Program
{
    static void Main(string[] args)
    {
        Configuration firstConfig = Configuration.Instance;
        firstConfig.SettingValue = "Custom Setting";
        Configuration secondConfig = Configuration.Instance;

        firstConfig.DisplaySetting();
        secondConfig.DisplaySetting();

        Console.WriteLine(ReferenceEquals(firstConfig, secondConfig));
    }
}
