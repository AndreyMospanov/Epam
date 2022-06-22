using System;

namespace _2._4_My_String
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString ms = new MyString();
            MyString ms2 = new MyString();
            Console.WriteLine($"Lets compare this myStrings. Is it Equal? {Environment.NewLine}{ms.myEquals(ms2)}");
            Console.WriteLine($"Lets compare this myStrings via overrde bool Equals(obj). Is it Equal? {Environment.NewLine}{ms.Equals(ms2)}");
            Console.WriteLine($"Lets concat them");
            ms.Concat(ms2).Print();
            Console.WriteLine($"Convert ms to Char Array");
            char[] arrChar = ms.ToCharArray();
            foreach (var item in arrChar)
            {
                Console.Write(item);
            }
            Console.WriteLine($"{Environment.NewLine}Convert char array to myString ms2");
            ms2 = new MyString(new char[] { 't', 'h', 'i', 's', 'i', 's', 'n', 'e', 'w', 'm', 's', '2' });
            ms2.Print();
            Console.WriteLine($"Lets Find 'q' in ms & ms2 {Environment.NewLine}{ms.Find('q')} {ms2.Find('q')}");
        }
    }
}
