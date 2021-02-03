using System;
using System.IO;
using System.Text.Json;

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
            ToDo[] tasks = null;
            if (File.Exists(path))
            {
                tasks = DeserializingTasks(path);
                OutputTasks(tasks);
            }
            ComandsForStartMenu();

            string enteredComand = Console.ReadLine();
            if (enteredComand == "exit")
            {
                Console.WriteLine("Всего доброго!");
                return;
            }

            ActionSelectionForStartMenu(enteredComand, tasks);
        }

        //Добавление задач в строку
        public static void AddTasksToTheTaskList(ToDo[] arrayTasks)
        {
            string tasks = "";
            Console.WriteLine("Чтобы вернуться в главное меню, введите exit");
            while (true)
            {
                Console.WriteLine("Введите описание задачи");
                string task = Console.ReadLine();

                if (task == "exit")
                {
                    SerializingTasks(GetArrayForSerialization(tasks, arrayTasks));
                    break;
                }
                else
                    tasks = tasks + task + ".";
            }
            
            StartMenu();
        }
        //Преобразование полученной строки с задачами в массив задач ToDo[]
        public static ToDo[] GetArrayForSerialization(string tasks, ToDo[] arrayTasks)
        {
            string[] arrayOfTasks = tasks.Split('.');
            ToDo[] toDoTasks = null;
            if (arrayTasks != null)
            {
                toDoTasks = new ToDo[arrayOfTasks.Length + arrayTasks.Length - 1];
                for (int i = 0; i < arrayTasks.Length; i++)
                {
                    toDoTasks[i] = arrayTasks[i];
                }
                for (int i = 0; i < arrayOfTasks.Length - 1; i++)
                {
                    toDoTasks[i + (arrayTasks.Length)] = new ToDo(arrayOfTasks[i]);
                }
                return toDoTasks;
            }
            else
            {
                toDoTasks = new ToDo[arrayOfTasks.Length - 1];
                for (int i = 0; i < arrayOfTasks.Length - 1; i++)
                {
                    toDoTasks[i] = new ToDo(arrayOfTasks[i]);
                }
                return toDoTasks;
            }
        }
        //Изменение статуса задач
        public static void ChangeTaskStatus(ToDo[] tasks)
        {
            Console.WriteLine("Чтобы вернуться в главное меню, введите exit");
            while (true)
            {
                Console.WriteLine("Введите номер задачи, статус которой хотите изменить");
                string numberOfTask = Console.ReadLine();
                if (numberOfTask == "exit")
                {
                    break;
                }
                else if (tasks == null)
                {
                    Console.WriteLine("Ваш список задач пуст. Нечего изменять.");
                    return;
                }
                else if (IsNum(numberOfTask) && Convert.ToInt32(numberOfTask) >= 0 && Convert.ToInt32(numberOfTask) < tasks.Length)
                {
                    Console.WriteLine("Статус задачи изменен");
                    switch (tasks[Convert.ToInt32(numberOfTask)].isDone)
                    {
                        case true:
                            tasks[Convert.ToInt32(numberOfTask)].isDone = false;
                            break;
                        case false:
                            tasks[Convert.ToInt32(numberOfTask)].isDone = true;
                            break;
                    }
                }
                else
                    Console.WriteLine("Некорректно указан номер задачи.");
            }
            SerializingTasks(tasks);
            StartMenu();
        }
        //Обработка выбранного пользователем пункта меню
        public static void ActionSelectionForStartMenu(string enteredComand, ToDo[] tasks)
        {
            if (IsNum(enteredComand) && Convert.ToInt32(enteredComand) == 1)
            {
                AddTasksToTheTaskList(tasks);
            }
            else if(IsNum(enteredComand) && Convert.ToInt32(enteredComand) == 2)
            {
                ChangeTaskStatus(tasks);
            }
            else if (enteredComand == "exit")
            {
                Console.WriteLine("Всего доброго!");
                return;
            }
            else
            {
                ComandsForStartMenu();
                enteredComand = Console.ReadLine();
                ActionSelectionForStartMenu(enteredComand, tasks);
            }
        }
        //Сериализация
        public static void SerializingTasks(ToDo[] tasks)
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", json);
            return;
        }
        //Десериализация
        public static ToDo[] DeserializingTasks(string path)
        {
            string json = File.ReadAllText(path);
            ToDo[] tasks = JsonSerializer.Deserialize<ToDo[]>(json);
            return tasks;
        }
        //Вывод десериализированного массива на экран
        public static void OutputTasks(ToDo[] tasks)
        {
            for (int i = 0; i < tasks.Length; i++)
            {
                bool isDoneValue = tasks[i].isDone;
                if (isDoneValue)
                {
                    Console.WriteLine($"{tasks[i].Title} \t X");
                }
                else
                {
                    Console.WriteLine($"{tasks[i].Title} \t V");
                }

            }
        }
        //Выбор команд для главного меню
        public static void ComandsForStartMenu()
        {
            Console.WriteLine("Чтобы добавить задачи в ваш Список задач, введите 1");
            Console.WriteLine("Чтобы изменить статус задачи, нажмите 2");
            Console.WriteLine("Чтобы выйти из приложения, введите exit");
        }

        //Проверка на число
        public static bool IsNum(string value) {
            if (int.TryParse(value, out int result))
            {
                return true;
            }
            return false;
        }

    }
}
