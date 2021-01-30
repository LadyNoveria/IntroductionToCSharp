using System;

namespace HW3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу — телефонный справочник — создать двумерный массив 5*2, 
             * хранящий список телефонных контактов: первый элемент хранит имя контакта, 
             * второй — номер телефона/e-mail.*/
            int numberOfElementsFirstArray = 5;
            int numberOfElementsSecondArray = 2;
            string[,] phonebook = new string[numberOfElementsFirstArray, numberOfElementsSecondArray];

            //Заполнение телефонного справочника
            fillingPhonebook(numberOfElementsFirstArray, numberOfElementsSecondArray, phonebook);

            //Вывод полученного массива на экран
            arrayOutput(numberOfElementsFirstArray, numberOfElementsSecondArray, phonebook);

            readKey();
        }
        //Заполнение телефонного справочника
        private static void fillingPhonebook(int numberOfElementsFirstArray, int numberOfElementsSecondArray, string[,] phonebook)
        {
            for (int i = 0; i < numberOfElementsFirstArray; i++)
            {
                for (int j = 0; j < numberOfElementsSecondArray; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Введите имя абонента");
                        phonebook[i, j] = Console.ReadLine();
                        continue;
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("Введите телефон абонента");
                        phonebook[i, j] = Console.ReadLine();
                        continue;
                    }
                }
            }
        }
        //Вывод полученного массива на экран
        private static void arrayOutput(int numberOfElementsFirstArray, int numberOfElementsSecondArray, string[,] phonebook)
        {
            Console.WriteLine("Полученный массив:");
            for (int i = 0; i < numberOfElementsFirstArray; i++)
            {
                for (int j = 0; j < numberOfElementsSecondArray; j++)
                {
                    Console.Write(phonebook[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void readKey()
        {
            Console.ReadKey();
        }
    }
}
