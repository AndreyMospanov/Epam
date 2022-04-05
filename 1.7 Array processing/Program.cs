using System;

/*1.7. ARRAY PROCESSING
Написать программу, которая генерирует случайным образом элементы массива (число элементов
в массиве и их тип определяются разработчиком), определяет для него максимальное и
минимальное значения, сортирует массив и выводит полученный результат на экран.
Примечание: LINQ запросы и готовые функции языка (Sort, Max и т.д.) использовать в данном
задании запрещается.*/
namespace _1._7_Array_processing
{
    class Program
    {
        private static int[] CreateArray(int length)
        {
            int[] arr = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(10, 100);                               
            }
            return arr;
        }
        private static void PrintArray(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {                
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write($"{arr[i]} ");
            }
        }
        private static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                min = min < arr[i] ? min : arr[i];
            }
            return min;
        }
        private static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                max = max > arr[i] ? max : arr[i];
            }
            return max;
        }
        private static void BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;                        
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr;
            Console.WriteLine("Введите длинну массива");
            int.TryParse(Console.ReadLine(), out int n);
            arr = CreateArray(n);
            PrintArray(arr);
            Console.WriteLine($"\nМинимальный член массива = {Min(arr)}, максимальный - {Max(arr)} ");
            BubbleSort(arr);
            PrintArray(arr);
        }
    }
}
