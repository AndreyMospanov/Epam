using System;
/*1.3. ANOTHER TRIANGLE
Написать программу, которая запрашивает с клавиатуры число N и выводит на экран равнобедренный треугольник состоящий из N строк(без использования string):*/

namespace _1._3_Another_Triangle
{
    class Program
    {
        private static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n * 2; i++)
            {
                if(i % 2 == 1)
                {                    
                    for (int j = 0; j < (n * 2 - i) / 2; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }                
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
