using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую элементы двухмерного массива по диагонали.
            Console.WriteLine("Введите размерность первого массива");
            int numberOfElementsFirstArray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размерность второго массива");
            int numberOfElementsSecondArray = Convert.ToInt32(Console.ReadLine());
            Random randomValue = new Random();
            int[,] arrayOfNumber = new int[numberOfElementsFirstArray, numberOfElementsSecondArray];

            //Заполнение массива рандомными знамениями от 0 до 10
            fillingArray(numberOfElementsFirstArray, numberOfElementsSecondArray, randomValue, arrayOfNumber);

            //Вывод полученного массива на экран
            arrayOutput(numberOfElementsFirstArray, numberOfElementsSecondArray, arrayOfNumber);

            Console.WriteLine("Вывод массива по диагонали");
            for (int i = 0; i < numberOfElementsFirstArray; i++)
            {
                int countI = 0;
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(arrayOfNumber[countI, j] + " ");
                    countI++;
                }
                Console.WriteLine();
            }

            for (int i = numberOfElementsFirstArray - 1; i > 0; i--)
            {
                int countI = 0;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(arrayOfNumber[countI, j] + " ");
                    countI++;
                }
                Console.WriteLine();
            }



            //Вывод главной диагонали массива
            //mainDiagonalOutput(numberOfElementsFirstArray, numberOfElementsSecondArray, arrayOfNumber);
            readKey();
        }

        static void arrayOutput(int numberOfElementsFirstArray, int numberOfElementsSecondArray, int[,] arrayOfNumber)
        {
            Console.WriteLine("Полученный массив:");
            for (int i = 0; i < numberOfElementsFirstArray; i++)
            {
                for (int j = 0; j < numberOfElementsSecondArray; j++)
                {
                    Console.Write(arrayOfNumber[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void fillingArray(int numberOfElementsFirstArray, int numberOfElementsSecondArray, Random randomValue, int[,] arrayOfNumber)
        {
            for (int i = 0; i < numberOfElementsFirstArray; i++)
            {
                for (int j = 0; j < numberOfElementsSecondArray; j++)
                {
                    arrayOfNumber[i, j] = randomValue.Next(0, 10);
                }
            }
        }

        private static void mainDiagonalOutput(int numberOfElementsFirstArray, int numberOfElementsSecondArray, int[,] arrayOfNumber)
        {
            Console.WriteLine("Главная диагональ:");
            for (int i = 0; i < numberOfElementsFirstArray; i++)
            {
                for (int j = 0; j < numberOfElementsSecondArray; j++)
                {
                    if (i == j)
                    {
                        Console.Write(arrayOfNumber[i, j]);
                    }
                }
            }
        }

        public static void readKey() {
            Console.ReadKey();
        }
    }
}
