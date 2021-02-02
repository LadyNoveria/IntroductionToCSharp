using System;
using System.Collections.Generic;
using System.Text;

namespace HW5._5
{
    class ToDo
    {
        public string Title { get; set; }
        public bool isDone { get; set; }
        public ToDo(){}
        public ToDo(string title)
        {
            Title = title;
            isDone = false;
        }
        public void Output(ToDo[] tasks)
        {
            for (int i = 0; i < tasks.Length; i++)
            {
                bool isDoneValue = tasks[i].isDone;
                if (isDoneValue)
                {
                    Console.WriteLine($"{tasks[i].Title} \t V");
                }
                else {
                    Console.WriteLine($"{tasks[i].Title} \t X");
                }
               
            }
        }
    }
}
