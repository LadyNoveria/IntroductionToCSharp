using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8ForFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать консольное приложение, которое при старте выводит приветствие, записанное в 
             * настройках приложения (application-scope). Запросить у пользователя имя, возраст и 
             * род деятельности, а затем сохранить данные в настройках. При следующем запуске 
             * отобразить эти сведения. Задать приложению версию и описание.*/

            if (string.IsNullOrEmpty(Properties.Settings.Default.userName))
            {
                Console.WriteLine("Enter your name");
                Properties.Settings.Default.userName = Console.ReadLine();
                do
                {
                    Console.WriteLine("Enter your age");
                    string userAge = Console.ReadLine();
                    if (IsNum(userAge))
                    {
                        Properties.Settings.Default.userAge = Convert.ToInt32(userAge);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect a value. Try again.");
                    }
                } while (true);

                Console.WriteLine("Enter your occupation");
                Properties.Settings.Default.occupation = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.WriteLine("Thank you! Good By!");
            }
            else
            {
                string greeting = Properties.Settings.Default.greeting;
                string userName = Properties.Settings.Default.userName;
                int userAge = Properties.Settings.Default.userAge;
                string occupation = Properties.Settings.Default.occupation;
                Console.WriteLine($"{greeting}, {occupation} {userName}! Your age is {userAge}. Not bad!");
            }
            Console.ReadKey();
        }
        public static bool IsNum(string value)
        {
            bool result = int.TryParse(value, out int intResult) ? true : false;
            return result;
        }
    }
}
