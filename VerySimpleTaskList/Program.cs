using System;

namespace VerySimpleTaskList
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Welcome to VerySimpleTaskList version 1.0");
            TaskManager manager = new TaskManager();
            manager.Run();
        }
    }
}
