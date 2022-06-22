using System;

namespace _2._5_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Director = new Employee();
            Director.ConsoleCreate();
            Console.WriteLine(Director.ToString()); 
        }
    }
}
