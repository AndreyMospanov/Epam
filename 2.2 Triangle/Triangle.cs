using System;
using System.Collections.Generic;
using System.Linq;
/*2.2. TRIANGLE
Написать класс Triangle, описывающий треугольник со сторонами a, b, c и позволяющий
осуществить расчёт его площади и периметра. Написать программу, демонстрирующую
использование данного треугольника.*/

namespace _2._2_Triangle
{
    class Triangle
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private List<double> _sides = new List<double>(3);
        public List<double> sides
        {
            get { return _sides; }
            set { 
                if(value != null)
                    _sides = value; }
        }

        public  Triangle(string name)
        {
            this._name = name;
            sides.Add(1);
            sides.Add(2);
            sides.Add(3);            
        }

        public void Create(double a, double b, double c)
        {
            sides[0] = a;   
            sides[1] = b;
            sides[2] = c;

            CheckTriangle();
        }
        public void CheckTriangle()
        {
            double hypotenuse = sides.Max();
            double cathet = sides.Min();
            double cathet2;
            List<double> temp = new List<double>();
            for (int i = 0; i < 3; i++)
            {
                temp.Add(sides[i]);
            }
            temp.Remove(temp.Min());
            temp.Remove(temp.Max());
            cathet2 = temp[0];
            if (hypotenuse > cathet + cathet2 || cathet <= 0)
            {
                Console.WriteLine("Sides impossible. Put down new sides");
                Console.WriteLine("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("c = ");
                double c = Convert.ToDouble(Console.ReadLine());
                this.Create(a, b, c);
            }
        }
        public double Perimeter(List<double> sides)
        {
            return sides.Sum();
        }
        public double Area(List<double> sides)
        {
            double hypotenuse = sides.Max();
            double cathet = sides.Min();
            double sinA = cathet / hypotenuse;
            List<double> temp = new List<double>();
            for (int i = 0; i < 3; i++)
            {
                temp.Add(sides[i]);
            }
            temp.Remove(temp.Min());
            temp.Remove(temp.Max());
            return 0.5 * hypotenuse * temp[0] * sinA;
        }
        public override string ToString()
        {
            if (sides != null && name != null)
                return $"{this.name} with sides {sides[0]} {sides[1]} {sides[2]} have a perimeter = {Perimeter(sides).ToString("F1")} & an area = {Area(sides).ToString("F1")}";
            else
                return "Triangle is not finished yet";
        }
    }
}
