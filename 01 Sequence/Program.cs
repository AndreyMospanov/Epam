using System;
using System.Text;

/*0.1. SEQUENCE
Написать функцию, формирующую и возвращающую строку вида 1, 2, 3, … N (положительное
число).
Значение N передаётся в функцию в качестве аргумента.
Пример возвращаемого значения для N=7: 1, 2, 3, 4, 5, 6, 7*/
namespace _01_Sequence
{
    class Program
    {
        private static string Print(int num)
        {
            string data = string.Empty;
            for(int i = 0; i < num; i++)
            {
                data += (i + 1).ToString() + ", ";
            }
            return data.Substring(0, data.Length - 2); ;
        }
        private static string Print2(int num)
        {
            int index = 1;
            StringBuilder sb = new StringBuilder();
            while(index != num + 1)
            {
                sb.Append($"{index}, ");
                index++;
            }
            return sb.ToString().Substring(0, sb.Length-2);
        }
       


        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Введите число: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(Print(num));
            Console.WriteLine(Print2(num));
            Console.ReadKey();
        }
    }
}
