using System;
using _2._1_Round;
/*2.6.RING
Создать класс Ring, описывающий кольцо, заданное координатами центра, внешним и внутренним
радиусами, а также свойствами, позволяющими узнать площадь кольца и суммарную длину
внешней и внутренней окружностей. Обеспечить нахождение класса в заведомо корректном
состоянии.*/

namespace _2._6_Ring
{
    class Ring
    {

        private Round _inner;
        private Round _outter;
        private string _name;

        public string name { get => _name; set => _name = value; }
        public Round inner { get => _inner; set => _inner = value; }
        public Round outter { get => _outter; set => _outter = value; }
        

        public double RingArea()
        {
            return outter.area(outter.radius) - inner.area(inner.radius);
        }
        public  double roundLength()
        {
            return 3.14 * Math.Pow(outter.radius, 2) + 3.14 * Math.Pow(inner.radius, 2); 
        }
        public override string ToString()
        {            
            return $"Ring {this.name} with coordinates = {inner.x}, {inner.y}; outter radius = {outter.radius}, inner radius = {inner.radius}, {Environment.NewLine}rounds length = {this.roundLength().ToString("F2")}, ring area = {this.RingArea().ToString("F2")}";
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
            inner = new Round();
            outter = new Round();
            this.name = "no name";
        }

        public void ConsoleCreate()
        {            
            Console.WriteLine("Enter Name of Ring");
            name = Console.ReadLine();
            Console.WriteLine("Enter Coordinates, x & y:");
            inner.x = EnterCorrectNum();
            inner.y = EnterCorrectNum();
            Console.WriteLine("Enter inner radius");
            inner.radius = EnterCorrectNumPositive();
            Console.WriteLine("Enter outter radius");
            outter.radius = EnterCorrectNumPositive();
        }
    }
}
