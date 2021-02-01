using System;
using System.IO;

namespace HW5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, которая при старте дописывает текущее время в файл «startup.txt».*/
            string filename = "startup.txt";
            DateTime date = DateTime.Now;
            string dateTime = date.ToString();
            File.AppendAllText(filename, dateTime);
            File.AppendAllText(filename, Environment.NewLine);
            //для проверки
            string fileText = File.ReadAllText(filename);
            Console.WriteLine($"Текст из файла: {fileText}");
            Console.ReadKey();
        }
    }
}
