using System;

namespace _2._2_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle Treugolnik = new Triangle("Treugolnik");            
            Treugolnik.sides.AddRange( new double[] {3.0, 4.0, 5.0 });
            Console.WriteLine(Treugolnik.ToString());
        }
    }
}
