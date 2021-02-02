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
    }
}
