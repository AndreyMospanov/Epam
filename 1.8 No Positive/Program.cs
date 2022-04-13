using System;
/*1.8. NO POSITIVE
Написать программу, которая заменяет все положительные элементы в трёхмерном массиве на
нули. Число элементов в массиве и их тип определяются разработчиком.*/
namespace _1._8_No_Positive
{
    class Program
    {        
        private static int[,,] CreateArray(int length)
        {
            int[,,] arr = new int[length, length, length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        arr[i, j, k] = random.Next(-9, 9);
                    }
                }                
            }
            return arr;
        }

        private static void PrintArray(int[,,] arr, int length)
        {            
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        if(arr[i,j,k] >= 0)
                        {
                            Console.Write($" {arr[i, j, k]} ");
                        }
                        else
                        {
                            Console.Write($"{arr[i, j, k]} ");
                        }                        
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        private static void EliminatePositive(int[,,] arr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        if(arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }                        
                    }                    
                }                
            }
        }

        static void Main(string[] args)
        {
            int[,,] arr;
            Console.WriteLine("Введите длину массива");
            int.TryParse(Console.ReadLine(), out int length);
            arr = CreateArray(length);
            PrintArray(arr, length);
            EliminatePositive(arr, length);
            Console.WriteLine("Изменённый массив:");
            PrintArray(arr, length);
        }
    }
}
