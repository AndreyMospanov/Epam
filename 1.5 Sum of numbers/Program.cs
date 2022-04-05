using System;
/*1.5. SUM OF NUMBERS
Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. Сумма
этих чисел будет равна 23. Напишите программу, которая выводит на экран сумму всех чисел
меньше 1000, кратных 3 или 5.*/
namespace _1._5_Sum_of_numbers
{
    class Program
    {
        private static int SumOfNumbers()
        {
            int sum = 0;
            for (int i = 0; i < 1001; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                    //Console.WriteLine(i);
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfNumbers()); 
        }
    }
}
