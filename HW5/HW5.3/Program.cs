using System;
using System.IO;
namespace HW5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.*/
            Console.WriteLine("Введите набор чисел, разделенных пробелом");
            string numbers = Console.ReadLine();
            byte[] setOfNumbers = GetArrayOfNumbers(numbers);

            File.WriteAllBytes("setOfNumbers.bin", setOfNumbers);
            ForCheck();
        }

        private static void ForCheck()
        {
            byte[] temp = File.ReadAllBytes("setOfNumbers.bin");
            Console.Write("Полученный массив чисел: ");
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write($"{temp[i]} ");
            }
        }

        static public byte[] GetArrayOfNumbers(string numbers)
        {
            string[] tempArray = numbers.Split(" ");
            byte[] setOfNumbers = new byte[tempArray.Length];
            for (int i = 0; i < tempArray.Length; i++)
            {
                setOfNumbers[i] = Convert.ToByte(tempArray[i]);
            }
            return setOfNumbers;
        }
    }
}
