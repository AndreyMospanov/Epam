using System;
using System.Collections.Generic;
using System.Text;
/*2.1. ROUND
Написать класс Round, задающий круг с указанными координатами центра, радиусом, а также
свойствами, позволяющими узнать длину описанной окружности и площадь круга. Обеспечить
нахождение объекта в заведомо корректном состоянии. Написать программу, демонстрирующую
использование данного круга.*/
namespace _2._1_Round
{
    public class Round
    {
        private double _x;
        private double _y;
        private double _radius;
        private string _name;
        
        public Round(string name)
        {
            this.name = name;
        }
        public Round()
        {
            
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double x
        {
            get { return _x; }
            set { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set { _y = value; }
        }
        public double radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public virtual double roundLength()
        {
            return 2 * 3.14 * radius;
        }
        public double area(double radius)
        {
            return 3.14 * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return $"{this.name} coordinates = {this.x}, {this.y}; radius = {this.radius}, {Environment.NewLine}round length = {this.roundLength().ToString("F2")}, round area = {this.area(this.radius)}";
        }
    }
}
