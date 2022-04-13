using System;
/*1.10. 2D ARRAY
Элемент двумерного массива считается стоящим на чётной позиции, если сумма номеров его
позиций по обеим размерностям является чётным числом (например, [1,1] — чётная позиция, а
[1,2] — нет). Определить сумму элементов массива, стоящих на чётных позициях.*/
namespace _1._10_Double_Array
{

    class Program
    {
        private static int[,] CreateArray(int length)
        {
            int[,] arr = new int[length, length];
            Random random = new Random();
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < length; k++)
                {
                    arr[j, k] = random.Next(-9, 9);
                }
            }
            return arr;
        }

        private static void PrintArray(int[,] arr, int length)
        {
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < length; k++)
                {
                    if (arr[j, k] >= 0)
                    {
                        Console.Write($" {arr[j, k]} ");
                    }
                    else
                    {
                        Console.Write($"{arr[j, k]} ");
                    }
                }
                Console.WriteLine();
            }            
        }
        private static int SumEvenElements(int [,] arr, int length)
        {
            int sum = 0;
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < length; k++)
                {
                    if ((j + k) % 2 == 0) 
                    {
                        sum += arr[j, k];                        
                    }                    
                }                
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] arr;

            Console.WriteLine("Enter array length");
            int.TryParse(Console.ReadLine(), out int length);
            arr = CreateArray(length);
            PrintArray(arr, length);
            Console.WriteLine($"Sum of even elements = {SumEvenElements(arr, length)}");
        }
    }
}
