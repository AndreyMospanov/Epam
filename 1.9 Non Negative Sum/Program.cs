using System;
/*1.9. NON-NEGATIVE SUM
Написать программу, которая определяет сумму неотрицательных элементов в одномерном
массиве. Число элементов в массиве и их тип определяются разработчиком.*/
namespace _1._9_Non_Negative_Sum
{
    class Program
    {
        private static double[] CreateArray(int length)
        {
            double[] arr = new double [length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(-1, 2) * 100 * random.NextDouble();
            }
            return arr;
        }
        private static void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write($"{arr[i]:f2} ");
            }
        }
        private static double Sum(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    sum += arr[i];
            }
            return sum;
        }
        
        static void Main(string[] args)
        {
            double[] arr;
            Console.WriteLine("Enter array length");
            int.TryParse(Console.ReadLine(), out int length);
            arr = CreateArray(length);
            PrintArray(arr);
            Console.WriteLine($"\nSum non negative = {Sum(arr):f2}");

        }
    }
}
