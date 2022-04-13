using System;

namespace _2._1_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            Round myRound = new Round("myRound");
            myRound.x = 0;
            myRound.y = 0;
            myRound.radius = 10.0;
            Console.WriteLine(myRound.ToString());
        }
    }
}
