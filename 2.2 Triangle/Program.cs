using System;

namespace _2._2_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle Treugolnik = new Triangle("Treugolnik");
            Treugolnik.Create(4, 5, 6);
            Console.WriteLine(Treugolnik.ToString());
        }
    }
}
