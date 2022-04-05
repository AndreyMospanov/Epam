using System;

namespace _1._4_Christmas_Tree
{
    class Program
    {
        private static void PrintTriangle(int n, int length)
        {
            for (int i = 1; i <= n * 2; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 0; j < (length * 2 - i) / 2; j++)
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
        private static void XMas(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintTriangle(i, n);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int.TryParse(Console.ReadLine(), out int n);
            XMas(n);
        }
    }
}

