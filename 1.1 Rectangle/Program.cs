using System;
/*1.1. RECTANGLE
Написать программу, которая определяет площадь прямоугольника со сторонами a и b. Если
пользователь вводит некорректные значения (отрицательные или ноль), должно выдаваться
сообщение об ошибке. Возможность ввода пользователем строки вида «абвгд» или нецелых чисел
игнорировать.
*/
namespace _1._1_Rectangle
{
    class Program
    {
        private static int GetInput()
        {
            int input = 0;
            try
            {
                Console.WriteLine("Введите сторону треугольника");
                int.TryParse(Console.ReadLine(), out  input);
                if(input < 1)
                {
                    throw new Exception(); 
                }
            }

            catch (Exception e) when (input == 0)
            {
                Console.WriteLine("Сторона прямоугольника не может быть равна 0");
                return GetInput();                
            }

            catch (Exception) when (input < 0)
            {
                Console.WriteLine("Сторона прямоугольника не может быть отрицательной");
                return GetInput();                
            }

            return input;
        }
        static void Main(string[] args)
        {
            int a, b;
            a = GetInput();
            b = GetInput();
            Console.WriteLine($"Площадь прямоугольника равна {a * b}");
            
        }
    }
}
