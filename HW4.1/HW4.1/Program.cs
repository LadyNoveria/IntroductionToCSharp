using System;

namespace HW4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать метод GetFullName(string firstName, string lastName, string patronymic), 
             * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
             * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.*/
            string[] users = GetUsers();
            OutputUsers(users);
            Console.ReadKey();
        }

        public static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }

        public static (string firstName, string lastName, string patronimyc) GetNames()
        {
            Console.WriteLine("Введите фамилию");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите имя");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите отчество");
            string patronymic = Console.ReadLine();

            return (firstName, lastName, patronymic);
        }

        public static string[] GetUsers()
        {
            Console.WriteLine("Введите количество пользователей");
            int countUsers = Convert.ToInt32(Console.ReadLine());
            string[] users = new string[countUsers];
            for (int i = 0; i < countUsers; i++)
            {
                (string firstName, string lastName, string patronimyc) = GetNames();
                users[i] = GetFullName(firstName, lastName, patronimyc);
            }
            return users;
        }
        public static void OutputUsers(string[] users)
        {
            Console.WriteLine("Сохраненные ФИО:");
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }
        }
    }
}
