namespace Singleton
{
    public class Configuration
    {
        private static Configuration _instance;

        private Configuration()
        {
            SettingValue = "Default Setting";
        }

        public static Configuration Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Configuration();
                }
                return _instance;
            }
        }

        public string SettingValue { get; set; }

        public void DisplaySetting()
        {
            Console.WriteLine("Current Setting: " + SettingValue);
        }
    }

}
