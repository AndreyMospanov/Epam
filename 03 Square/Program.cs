using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*0.3. SQUARE
Написать функцию, выводящую на экран квадрат из звёздочек со стороной равной N
(положительное нечётное целое число). Центральная звёздочка должна отсутствовать.
Значение N передаётся в функцию в качестве аргумента.
На изображении приведён пример работы функции для N=7.*/

namespace _03_Square
{
    class Program
    {
        private static void PrintStarArr(int num)
        {
            int[,] arr;
            arr = new int[num, num];

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if(i == num/2  && j == num / 2 )
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            int num;            
            Console.WriteLine("Введите число");
            num = int.Parse(Console.ReadLine());            
            PrintStarArr(num);
            Console.ReadKey();
        }
    }
}
