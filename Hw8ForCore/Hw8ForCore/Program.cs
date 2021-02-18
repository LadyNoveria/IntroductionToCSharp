using System;
using System.Configuration;
using System.Collections.Specialized;
namespace HW8ForCore
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках приложения 
             * (application-scope). Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в 
             * настройках. При следующем запуске отобразить эти сведения. Задать приложению версию и описание.*/
            var appSettings = ConfigurationManager.AppSettings;
            
            if (appSettings.Count <= 1)
            {
                string name = "name";
                string age = "age";
                string occupation = "occupation";

                Console.WriteLine("Enter your occupation");
                string userOccupation = Console.ReadLine();
                AddUpdateAppSetting(occupation, userOccupation);

                Console.WriteLine("Enter your name");
                string userName = Console.ReadLine();
                AddUpdateAppSetting(name, userName);

                do
                {
                    Console.WriteLine("Enter your age");
                    string userAge = Console.ReadLine();
                    if (IsNum(userAge))
                    {
                        AddUpdateAppSetting(age, userAge);
                        break;
                    }
                    else
                        Console.WriteLine("Incorrect value. Try again.");
                } while (true);
                
                Console.WriteLine("Settings was write. Good by!");
            }
            else {
                ReadAllSetting(appSettings);
            }
        }
        static public void ReadAllSetting(NameValueCollection appSettings)
        {
            try
            {
                string userAge = "";
                foreach (var key in appSettings.AllKeys)
                {
                    if (key == "age")
                    {
                        userAge = $". Your age is {appSettings[key]}. Not bad!";
                        continue;
                    }
                    else if (key == "name") {
                        Console.Write("{0}", appSettings[key]);
                        continue;
                    }
                    Console.Write("{0} ", appSettings[key]);
                }
                Console.WriteLine(userAge);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }
        static public void AddUpdateAppSetting(string key, string value)
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
                Console.WriteLine("Error writing app setting");
            }
        }
        static public bool IsNum(string value)
        {
            bool result = int.TryParse(value, out int intResult) ? true : false;
            return result;
        }
    }
}
