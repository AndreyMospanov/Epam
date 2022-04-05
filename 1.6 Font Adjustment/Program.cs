using System;
using System.Collections.Generic;
/*1.6. FONT ADJUSTMENT
Для форматирования текста надписи можно использовать различные начертания: полужирное,
курсивное и подчёркнутое, а также их сочетания. Предложите способ хранения информации о
форматировании текста надписи и напишите программу, которая позволяет устанавливать и
изменять начертание:*/
namespace _1._6_Font_Adjustment
{   
    class Program
    {
        enum fontOpt
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 3
        }
       private static List<int> ReadOpt( List<int> options)
        {            
            int.TryParse(Console.ReadLine(), out int input);
            if(input > 3)
            {
                Console.WriteLine("Значение не может быть больше 3");
                return ReadOpt(options);
            }
            else
            {
                if(input > 0)
                {    
                    if(options.Contains(input))
                    {
                        options.Remove(input);
                    }
                    else
                    {
                        options.Add(input);
                    }
                    if(options.Count == 0)
                    {
                        options.Add(0);
                    }
                    else
                    {
                        options.Remove(0);
                    }
                }
                return options;
            }
        }
        static void PrintOpt(List<int> opt)
        {
            foreach (var item in opt)
            {
                Console.Write($"{(fontOpt)(item)} ");
            }
        }
        static void Main(string[] args)
        {
            List<int> options = new List<int>();
            options.Add(0);
            while(true)
            {
                Console.Write($"Параметры надписи: ");
                PrintOpt(options);
                Console.WriteLine("\nВведите:\n1: Bold\n2: Italic\n3: Underline");
                options = ReadOpt(options);
            }
        }
        
    }
}
