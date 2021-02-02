using System;
using System.IO;
using System.Text.Json;
using HW5._5;

namespace HW5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu();
        }
        
        public static void StartMenu()
        {
            string path = @"tasks.json";
            if (File.Exists(path))
            {
                //Запустить десериализацию DeserializingTasks();
                ToDo[] tasks = DeserializingTasks(path);
                //Вывести содержимое на экран OutputTasks();
                OutputTasks(tasks);
                ComandsForStartMenu();
            }
            else
            {
                Console.WriteLine("Ваш список задач пуст");
                ComandsForStartMenu2();
            }
            string enteredComand = Console.ReadLine();
            if (IsNum(enteredComand))
            {
                if (Convert.ToInt32(enteredComand) == 0)
                {
                    Console.WriteLine("Всего доброго!");
                    return;
                }
                else
                {
                    ActionSelectionForStartMenu(enteredComand);
                }
            }
        }

        public static ToDo[] DeserializingTasks(string path)
        {
            string json = File.ReadAllText(path);
            ToDo[] tasks = JsonSerializer.Deserialize<ToDo[]>(json);
            return tasks;
        }

        public static void OutputTasks(ToDo[] tasks)
        {
            for (int i = 0; i < tasks.Length - 1; i++)
            {
                Console.WriteLine($"{tasks[i].Title}        {tasks[i].isDone}");
            }
        }
        public static void AddTasksToTheTaskList()
        {
            string tasks = "";
            Console.WriteLine("Чтобы вернуться в главное меню, введите 1");
            while (true)
            {
                Console.WriteLine("Введите описание задачи");
                string task = Console.ReadLine();
                if (IsNum(task)){
                    if (Convert.ToInt32(task) == 0)
                    {
                        Console.WriteLine("Всего доброго!");
                        SerializingTasks(GetArrayForSerialization(tasks));
                        return;
                    }
                    else if(Convert.ToInt32(task) == 1)
                    {
                        StartMenu();
                    }
                }
                tasks += $"{task};";
            }
        }

        public static void SerializingTasks(ToDo[] tasks)
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", json);
            return;
        }

        public static ToDo[] GetArrayForSerialization(string tasks)
        {
            string[] arrayOfTasks = tasks.Split(';');
            ToDo[] toDoTasks = new ToDo[arrayOfTasks.Length];
            for (int i = 0; i < arrayOfTasks.Length; i++)
            {
                toDoTasks[i] = new ToDo(arrayOfTasks[i]);
            }
            return toDoTasks;
        }
        public static void ChangeTaskStatus()
        {
            //ComandForMenuAddAndChangeTasks();
        }
        public static void ActionSelectionForStartMenu(string enteredComand)
        {
            switch (Convert.ToInt32(enteredComand))
            {
                case 1:
                    //добавление задач в список 
                    AddTasksToTheTaskList();
                    break;
                case 2:
                    //изменить статус задачи
                    ChangeTaskStatus();
                    break;
            }
        }

        public static void ComandsForStartMenu()
        {
            Console.WriteLine("Чтобы добавить задачи в ваш Список задач, введите 1");
            Console.WriteLine("Чтобы изменить статус задачи, нажмите 2");
            Console.WriteLine("Чтобы выйти из приложения, нажмите 0");
        }
        public static void ComandsForStartMenu2() {
            Console.WriteLine("Чтобы добавить задачи в ваш Список задач, введите 1");
            Console.WriteLine("Чтобы выйти из приложения, нажмите 0");
        }
        public static bool IsNum(string value) {
            if (int.TryParse(value, out int result))
            {
                return true;
            }
            return false;
        }

    }
}
