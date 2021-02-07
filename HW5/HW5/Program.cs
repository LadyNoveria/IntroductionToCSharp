using System;
using System.IO;
namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любую строку");
            string inputString = Console.ReadLine();
            string filename = "startup.txt";
            File.WriteAllText(filename, inputString);

            //для проверки
            string fileText = File.ReadAllText(filename);
            Console.WriteLine($"Текст из файла: {fileText}");
            Console.ReadKey();
        }
    }
}
