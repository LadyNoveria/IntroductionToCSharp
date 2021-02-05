using System;

namespace HW4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и 
             * возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат 
             * на экран.*/

            GetNumericalSequence(out string[] arrayOfNumbers);
            int summ = GetSummOfNumericalSequence(arrayOfNumbers);
            Console.WriteLine($"Сумма введенных чисел: {summ}");
            ReadKey();
        }

        public static void ReadKey() {
            Console.ReadKey();
        }
        public static int GetSummOfNumericalSequence(string[] arrayOfNumbers) {
            int summ = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                summ += Convert.ToInt32(arrayOfNumbers[i]);
            }
            return summ;
        }
        public static string[] GetNumericalSequence(out string[] arrayOfNumbers) {
            Console.WriteLine("Введите последовательность чисел, разделенных пробелом");
            string numericalSequence = Console.ReadLine();
            arrayOfNumbers = numericalSequence.Split(" ");
            return arrayOfNumbers;
        }
    }
}
