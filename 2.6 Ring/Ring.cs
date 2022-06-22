using System;
using _2._1_Round;
/*2.6.RING
Создать класс Ring, описывающий кольцо, заданное координатами центра, внешним и внутренним
радиусами, а также свойствами, позволяющими узнать площадь кольца и суммарную длину
внешней и внутренней окружностей. Обеспечить нахождение класса в заведомо корректном
состоянии.*/

//Переделать на агрегацию с двумя Rounds////

namespace _2._6_Ring
{
    class Ring : Round
    {
        private double _innerRadius;

        public double InnerRadius { get => _innerRadius; set => _innerRadius = value; }
        public double RingArea()
        {
            return this.area(radius) - this.area(InnerRadius);
        }
        public override double roundLength()
        {
            return 3.14 * Math.Pow(radius, 2) + 3.14 * Math.Pow(InnerRadius, 2); 
        }
        public override string ToString()
        {
            return $"Ring {this.name} with coordinates = {this.x}, {this.y}; outer radius = {this.radius}, inner radius = {this.InnerRadius}, {Environment.NewLine}rounds length = {this.roundLength().ToString("F2")}, round area = {this.RingArea().ToString("F2")}";
        }
        public double EnterCorrectNum()
        {
            double num;
            try
            {
                double.TryParse(Console.ReadLine(), out num);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Input! Try again.");
                return EnterCorrectNum();
            }
            return num;
        }public double EnterCorrectNumPositive()
        {
            double num = 0;
            try
            {
                double.TryParse(Console.ReadLine(), out num);
            }
            catch (Exception e) when (num < 0)
            {
                Console.WriteLine("radius should be positive");
                return EnterCorrectNumPositive();
            }
            catch (Exception) when (num == 0)
            {
                Console.WriteLine("Wrong Input! Try again.");
                return EnterCorrectNumPositive();
            }            
            return num;
        }
        public Ring()
        {
            Console.WriteLine("Enter Name of Ring");
            name = Console.ReadLine();
            Console.WriteLine("Enter Coordinates, x & y:");
            x = EnterCorrectNum();
            y = EnterCorrectNum();
            Console.WriteLine("Enter inner radius");
            InnerRadius = EnterCorrectNumPositive();
            Console.WriteLine("Enter outter radius");
            radius = EnterCorrectNumPositive();
            Console.WriteLine(this.ToString());
        }
    }
}
