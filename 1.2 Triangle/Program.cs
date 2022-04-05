using System;

/*1.2. TRIANGLE
Написать программу, которая запрашивает с клавиатуры число N и выводит на экран прямоугольный треугольник, состоящий из N строк(без использования string):
*
**
***
****
*****/
namespace _1._2_Triangle
{
    class Program
    {
        private static void PrintTriangle(int n)
        {            
            for(int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int.TryParse(Console.ReadLine(), out int n);
            PrintTriangle(n);
        }
    }
}
