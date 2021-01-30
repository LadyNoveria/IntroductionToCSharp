using System;

namespace HW3._4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ships = {0, 0, 0, 1, 0, 5, 2, 4, 3, 4, 3, 7, 3, 8, 3, 9, 4, 1, 4, 4, 5, 6, 6, 1, 6, 2, 6, 6, 6, 9, 8, 4, 8, 5, 8, 6, 8, 7, 9, 9};
            int arraySise = 10;
            string[,] seaBattle = new string[arraySise, arraySise];
            for (int i = 0; i < seaBattle.GetLength(0); i++)
            {
                for (int j = 0; j < seaBattle.GetLength(1); j++)
                {
                    string simbolArray = getSimbolArray(i, j, ships);
                    seaBattle[i, j] = simbolArray;
                    Console.Write(simbolArray);
                }
                Console.WriteLine();
            }
        }

        //Получение символа для заполнения массива
        public static string getSimbolArray(int x, int y, int[] ships)
        {
            string simbolArray = "O";
            for (int i = 0; i < ships.Length; i++)
            {
                if (ships[i] == x && ships[i + 1] == y)
                {
                    simbolArray = "X";
                    break;
                }
                else
                {
                    i++;
                }
            }
            return simbolArray;
        }
    }
}
