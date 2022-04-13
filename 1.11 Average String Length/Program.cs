using System;
using System.Text;
/*1.11. AVERAGE STRING LENGTH
Написать программу, которая определяет среднюю длину слова во введённой текстовой строке.
Учесть, что символы пунктуации на длину слов влиять не должны. Регулярные выражения не
использовать. И не пытайтесь прописать все символы-разделители ручками. Используйте
стандартные методы классов String и Char.*/

namespace _1._11_Average_String_Length
{    
    class Program
    {        
        static void PrintArray (string[] input)//for debug
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]); 
            }
        }
        static int AverageLength(string data)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(data);
            int average = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (Char.IsPunctuation(sb[i]))
                {
                    sb = sb.Replace(sb[i], ' ');
                }
            }            
            string[] dataSplit = sb.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //PrintArray(dataSplit);
            for (int i = 0; i < dataSplit.Length; i++)
            {
                average += dataSplit[i].Length;
            }
            return average / dataSplit.Length;
        }
        static void Main(string[] args)
        {
            string data = "1.11. AVERAGE STRING LENGTH Написать программу, которая определяет среднюю длину слова во введённой текстовой строке. " +
                 "Учесть, что символы пунктуации на длину слов влиять не должны.Регулярные выражения не использовать." +
                 "И не пытайтесь прописать все символы-разделители ручками.Используйте " +
                 "стандартные методы классов String и Char.";

            Console.WriteLine($"Average length of the words in this string:{Environment.NewLine}{data} = {AverageLength(data)}");
        }
    }
}
