using System;

/*0.2. SIMPLE
Число считается простым, если его можно разделить без остатка только на единицу и на само себя
(например, 7).
Необходимо написать функцию, определяющую, является ли заданное число N (положительное
целое) простым.
Значение N передаётся в функцию в качестве аргумента*/

namespace _02_Simple
{
    class Program
    {
        private static bool DetectNatural(int num)
        {
            for(int i = 2; i < num; i ++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Введите число: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число простое?\nОтвет: {DetectNatural(num)}");
            Console.ReadKey();
        }
    }
}
