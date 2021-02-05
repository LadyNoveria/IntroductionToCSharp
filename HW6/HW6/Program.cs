using System;
using System.Diagnostics;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать консольное приложение Task Manager, которое выводит на экран запущенные 
             * процессы и позволяет завершить указанный процесс. Предусмотреть возможность завершения
             * процессов с помощью указания его ID или имени процесса. В качестве примера можно 
             * использовать консольные утилиты Windows tasklist и taskkill.*/

            Process notepad = Process.Start("notepad.exe");
            OutputAvailableProcesses();

            Console.ReadKey();
        }
        //Стартовое меню с выводом на экран всех доступных процессов
        public static void OutputAvailableProcesses()
        {
            Process[] allProcesses = Process.GetProcesses();
            Console.WriteLine("Available running processes");
            Console.WriteLine("ID \t Name \t Memory Sise");

            for (int i = 0; i < allProcesses.Length; i++)
            {
                try
                {
                    Console.WriteLine($"{allProcesses[i].Id} \t {allProcesses[i].ProcessName} \t {allProcesses[i].VirtualMemorySize64}");
                }
                catch
                {
                    Console.WriteLine("Access Denied!");
                }
            }
            Menu();
            HandlingUserActions(allProcesses);
        }
        //Завершение процесса по его ID или имени
        public static void KillProcess(Process[] allProcesses)
        {
            Console.WriteLine("Enter the name or id of the process you want to end");
            Console.WriteLine("To return to the previous menu, enter \"exit\"");
            string processIdOrName = Console.ReadLine();
            if (processIdOrName == "exit")
            {
                OutputAvailableProcesses();
            }
            else if (IsNum(processIdOrName))
            {
                long processID = long.Parse(processIdOrName);
                for (int i = 0; i < allProcesses.Length; i++)
                {
                    if (processID == allProcesses[i].Id)
                    {
                        allProcesses[i].Kill();
                        Console.WriteLine($"Process whit ID {processID} complited.");
                        break;
                    }
                    else if (i == (allProcesses.Length - 1))
                    {
                        Console.WriteLine("There is no process with this id. Try again.");
                    }
                }
                KillProcess(allProcesses);
            }
            else
            {
                for (int i = 0; i < allProcesses.Length; i++)
                {
                    if (processIdOrName.ToLower() == allProcesses[i].ProcessName.ToLower())
                    {
                        allProcesses[i].Kill();
                        Console.WriteLine($"Process whit name {processIdOrName} complited.");
                        break;
                    }
                    else if (i == (allProcesses.Length - 1))
                    {
                        Console.WriteLine("There is no process with this name. Try again.");
                    }
                }
                KillProcess(allProcesses);
            }
        }
        //Обработка выбора пользователя
        static public void HandlingUserActions(Process[] allProcesses)
        {
            string enteredValue = Console.ReadLine();
            if (enteredValue == "exit")
            {
                Console.WriteLine("Good Bye!");
                return;
            }
            else if(IsNum(enteredValue) && Convert.ToInt32(enteredValue) == 1){
                KillProcess(allProcesses);
            }
            else
            {
                Menu();
                HandlingUserActions(allProcesses);
            }
        }
        //Проверка на число
        public static bool IsNum(string value)
        {
            return int.TryParse(value, out int result);
        }
        //Меню для пользователя
        public static void Menu()
        {
            Console.WriteLine("To close the application enter \"exit\"");
            Console.WriteLine("To end a specific proccess, enter 1");
        }
    }
}
