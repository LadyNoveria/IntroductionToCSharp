using System;

namespace HW2._6
{
    class Program
    {
        public enum DaysOfWeek { 
            Monday = 0b0000001,
            Thuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000
        }
        static void Main(string[] args)
        {
            /*(*) Для полного закрепления битовых масок, 
             * попытайтесь создать универсальную структуру расписания недели, 
             * к примеру, чтобы описать работу какого либо офиса. Явный пример - 
             * офис номер 1 работает со вторника до пятницы, офис номер 2 работает
             * c понедельника до воскресенья.*/

            //Офис 1 работает с понедельника по пятницу
            //Офис 2 работает с воскресенья по пятницу
            //Офис 3 работает в субботу и воскресенье
            //Маски для офисов
            DaysOfWeek officeOneMask = DaysOfWeek.Monday | DaysOfWeek.Thuesday | DaysOfWeek.Wednesday | DaysOfWeek.Thursday | DaysOfWeek.Friday;
            DaysOfWeek officeTwoMask = DaysOfWeek.Monday | DaysOfWeek.Thuesday | DaysOfWeek.Wednesday | DaysOfWeek.Thursday | DaysOfWeek.Friday | DaysOfWeek.Sunday;
            DaysOfWeek officeThreeMask = DaysOfWeek.Saturday | DaysOfWeek.Sunday;

            Console.WriteLine("Введите день недели");
            string userEnteredValue = Console.ReadLine();
            DaysOfWeek userEnteredDay = CheckEnteredValue(userEnteredValue);

            //Применение масок офисов для введенного пользователем дня
            DaysOfWeek officeOneDayOfWeek = officeOneMask & userEnteredDay;
            DaysOfWeek officeTwoDayOfWeek = officeTwoMask & userEnteredDay;
            DaysOfWeek officeThreeDayOfWeek = officeThreeMask & userEnteredDay;
            if (userEnteredDay == 0) {
                Console.WriteLine("Введённое значение не корректно");
            }
            else
                displayResults(userEnteredDay, officeOneDayOfWeek, officeTwoDayOfWeek, officeThreeDayOfWeek);

            readKey();
        }

        //Узнаем, какие из офисов работают в заданный пользователем день
        private static void displayResults(DaysOfWeek userEnteredDay, DaysOfWeek officeOneDayOfWeek, DaysOfWeek officeTwoDayOfWeek, DaysOfWeek officeThreeDayOfWeek)
        {
            if (userEnteredDay == officeOneDayOfWeek && userEnteredDay == officeTwoDayOfWeek && userEnteredDay == officeThreeDayOfWeek)
            {
                Console.WriteLine("В этот день работают все офисы");
            }
            else if (userEnteredDay == officeOneDayOfWeek && userEnteredDay == officeTwoDayOfWeek)
            {
                Console.WriteLine("В этот день работают офисы 1 и 2");
            }
            else if (userEnteredDay == officeOneDayOfWeek && userEnteredDay == officeThreeDayOfWeek)
            {
                Console.WriteLine("В этот день работают офисы 1 и 3");
            }
            else if (userEnteredDay == officeThreeDayOfWeek && userEnteredDay == officeTwoDayOfWeek)
            {
                Console.WriteLine("В этот день работают офисы 2 и 3");
            }
            else if (userEnteredDay == officeOneDayOfWeek)
            {
                Console.WriteLine("В этот день работает офис 1");
            }
            else if (userEnteredDay == officeTwoDayOfWeek)
            {
                Console.WriteLine("В этот день работает офис 2");
            }
            else if (userEnteredDay == officeThreeDayOfWeek)
            {
                Console.WriteLine("В этот день работает офис 3");
            }
        }

        //Сравнить введенное пользователем значение со значениями в enum
        private static DaysOfWeek CheckEnteredValue(string userEnteredValue)
        {
            DaysOfWeek userEnteredDay;
            switch (userEnteredValue.ToLower())
            {
                case "monday":
                    userEnteredDay = DaysOfWeek.Monday;
                    break;
                case "thuesday":
                    userEnteredDay = DaysOfWeek.Thuesday;
                    break;
                case "wednesday":
                    userEnteredDay = DaysOfWeek.Wednesday;
                    break;
                case "thursday":
                    userEnteredDay = DaysOfWeek.Thursday;
                    break;
                case "friday":
                    userEnteredDay = DaysOfWeek.Friday;
                    break;
                case "saturday":
                    userEnteredDay = DaysOfWeek.Saturday;
                    break;
                case "sunday":
                    userEnteredDay = DaysOfWeek.Sunday;
                    break;
                default:
                    userEnteredDay = 0;
                    break;
            }

            return userEnteredDay;
        }

        public static void readKey() {
            Console.ReadKey();
        }
    }
}
