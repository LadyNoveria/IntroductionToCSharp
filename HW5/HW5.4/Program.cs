using System;
using System.IO;

namespace HW5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.*/

            string workDir = @"Вставьте_любой_путь\TestMainDir";
            if (!Directory.Exists(workDir))
            {
                CreatingDirectoryTree(workDir);
            }
            //Сохранение дерева каталогов и файлов с помощью рекурсии
            WalkDirectoryTree(workDir); 

            //Сохранение дерева каталогов и файлов с помощью цикла
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);
            SaveEntriesUsingCicle(entries);

            Console.ReadKey();
        }

        static void WalkDirectoryTree(string workDir)
        {
            string[] files = Directory.GetFiles(workDir);

            if (files != null)
            {
                foreach (string fi in files)
                {
                    Console.WriteLine(fi);
                    File.AppendAllText("SaveEntriesUsingRecursion.txt", fi);
                    File.AppendAllText("SaveEntriesUsingRecursion.txt", Environment.NewLine);
                }

                string[] subDirs = Directory.GetDirectories(workDir);

                foreach (string dirInfo in subDirs)
                {
                    Console.WriteLine(dirInfo);
                    File.AppendAllText("SaveEntriesUsingRecursion.txt", dirInfo);
                    File.AppendAllText("SaveEntriesUsingRecursion.txt", Environment.NewLine);
                    WalkDirectoryTree(dirInfo);
                }
            }
        }

        public static void CreatingDirectoryTree(string workDir)
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

        public static void SaveEntriesUsingCicle(string[] entries)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                File.AppendAllText("SaveEntriesUsingCicle.txt", entries[i]);
                File.AppendAllText("SaveEntriesUsingCicle.txt", Environment.NewLine);
            }
        }
    }
}