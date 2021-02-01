using System;
using System.IO;

namespace HW5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.*/

            string workDir = @"C:\Users\littl\Desktop\IntroductionToCSharp\TestMainDir";
            if (!Directory.Exists(workDir))
            {
                CreatingDirectoryTree(workDir);
            }
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);
            //Вывод полученного массива на экран
            OutputEntries(entries);

            int count = 0;
            //Сохранение дерева каталогов с помощью рекурсии
            SaveEntriesUsingRecursion(entries, count, entries[count]);
            //Сохранение дерева каталогов с помощью цикла
            SaveEntriesUsingCicle(entries);
            Console.ReadKey();
        }
        public static void SaveEntriesUsingCicle(string[] entries)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                File.AppendAllText("SaveEntriesUsingCicle.txt", entries[i]);
                File.AppendAllText("SaveEntriesUsingCicle.txt", Environment.NewLine);
            }

        }
        private static void OutputEntries(string[] entries)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
            }
        }

        public static string SaveEntriesUsingRecursion(string[] entries, int count, string value)
        {
            File.AppendAllText("SaveEntriesUsingRecursion.txt", value);
            File.AppendAllText("SaveEntriesUsingRecursion.txt", Environment.NewLine);
            count++;
            if (count == entries.Length)
            {
                return value;
            }
            return SaveEntriesUsingRecursion(entries, count, entries[count]);
        }
       
        private static void CreatingDirectoryTree(string workDir)
        {
            //Creating directories
            string testMainDir = Path.Combine(workDir, "TestMainDir");
            Directory.CreateDirectory(testMainDir);
            string documentsDir = Path.Combine(testMainDir, "Documents");
            string notesDir = Path.Combine(testMainDir, "Notes");
            string articlesDir = Path.Combine(testMainDir, "Articles");
            Directory.CreateDirectory(documentsDir);
            Directory.CreateDirectory(notesDir);
            Directory.CreateDirectory(articlesDir);
            string usefulDir = Path.Combine(articlesDir, "Useful");
            Directory.CreateDirectory(usefulDir);
            //Creating files
            string note1Path = Path.Combine(notesDir, "Note1.txt");
            string note2Path = Path.Combine(notesDir, "Note2.txt");
            string article1Path = Path.Combine(articlesDir, "Article1.txt");
            string article2Path = Path.Combine(usefulDir, "UsefulArticle2.txt");
            string article3Path = Path.Combine(usefulDir, "UsefulArticle3.txt");
            File.Create(note1Path);
            File.Create(note2Path);
            File.Create(article1Path);
            File.Create(article2Path);
            File.Create(article3Path);
        }
    }
}
