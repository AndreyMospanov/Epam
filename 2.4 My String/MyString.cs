using System;

/*2.4. MY STRING
Написать свой собственный класс MyString, описывающий строку как массив символов.
Реализовать для этого класса типовые операции (сравнение, конкатенация, поиск символов,
конвертация из/в массив символов, ...).*/
namespace _2._4_My_String
{
    class MyString
    {
        private char[] _data;
        public char[] data
        {
            get { return _data; }
            set { _data = value; }
        }
        public MyString(char [] input)
        {
            this.data = input;
        }
        public MyString()
        {
            Console.WriteLine("print myString");
            this.data = Console.ReadLine().ToCharArray();
        }

        public bool Equals(MyString comparedString)
        {
            if(this.data.Length != comparedString.data.Length)
            {
                return false;
            }
            for (int i = 0; i < this.data.Length; i++)
            {
                if(this.data[i].ToString().ToLower() != comparedString.data[i].ToString().ToLower())
                {
                    return false;
                }
            }
            return true;
        }
        public MyString Concat(MyString summand)
        {
            char[] newMyString = new char[this.data.Length + summand.data.Length];
            int i, k;
            int j = 0;
            for (i = 0; i < this.data.Length; i++)
            {
                newMyString[i] = this.data[i];
            }
            for (k = i; k < newMyString.Length; k++, j++)
            {
                newMyString[k] = summand.data[j];
            }
            this.data = newMyString;            
            return this;
        }
        public bool Find(char search)
        {
            for (int i = 0; i < this.data.Length; i++)
            {
                if(this.data[i] == search)
                {
                    return true;
                }
            }
            return false;
        }
        public char[] ToCharArray()
        {
            return this.data;
        }
        public void Print()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]);
            }
            Console.WriteLine($"{Environment.NewLine}");
        }
    }
}
