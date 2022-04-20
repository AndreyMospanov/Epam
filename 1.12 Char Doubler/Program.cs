using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
/*1.12. CHAR DOUBLER
Написать программу, которая удваивает в первой введённой строке все символы, принадлежащие
второй введённой строке.
Пример:
Введите первую строку: написать программу, которая
Введите вторую строку: описание
Результирующая строка: ннааппииссаать ппроограамму, коотоораая*/
namespace _1._12_Char_Doubler
{
    class Program
    {
        private static string CharDoubler(string data, string modifier)
        {
            StringBuilder sb = new StringBuilder();
            HashSet<char> modList = new HashSet<char>(modifier.ToArray());
            
            
            
            for(int i = 0; i < data.Length ; i++)
            {                
                sb.Append(data[i]);
                if (modList.Contains((char)data[i]))
                {                   
                    sb.Append(data[i]);
                }
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string data = "написать программу, которая";
            string modifier = "описание";
            string result = "ннааппииссаать ппроограамму, коотоораая";
            
            Console.WriteLine(CharDoubler(data, modifier));
            Console.WriteLine(CharDoubler(data, modifier).Equals(result));
        }
    }
}
