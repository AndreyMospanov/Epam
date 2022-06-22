using System;
using System.Collections.Generic;
using System.Text;
/*2.3. USER
Написать класс User, описывающий человека (Фамилия, Имя, Отчество, Дата рождения, Возраст).
Написать программу, демонстрирующую использование этого класса.*/

namespace _2._3_User
{
    public class User
    {
        private string _surName;
        private string _name;
        private string _fathersName;
        private DateTime _birthDate;
        public string surName
        {
            get { return _surName; }
            set { _surName = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string fathersName
        {
            get { return _fathersName; }
            set { _fathersName = value; }
        }
        DateTime SetBirthDay()
        {
            Console.WriteLine("Enter birth year");
            int.TryParse(Console.ReadLine(), out int year);
            Console.WriteLine("Enter birth month");
            int.TryParse(Console.ReadLine(), out int month);
            Console.WriteLine("Enter birth day");
            int.TryParse(Console.ReadLine(), out int day);            
            return new DateTime(year, month, day);
        }
        public DateTime birthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public int age()
        {
            if(DateTime.Now.Month > birthDate.Date.Month)
            {
                return DateTime.Now.Year - birthDate.Year;
            }
            else if(DateTime.Now.Month < birthDate.Date.Month)
            {
                return DateTime.Now.Year - birthDate.Year - 1;
            }
            else
            {
                if(DateTime.Now.Day >= birthDate.Day)
                {
                    return DateTime.Now.Year - birthDate.Year;
                }
                else
                {
                    return DateTime.Now.Year - birthDate.Year - 1;
                }
            }
        }
        public override string ToString()
        {
            return $"You've created new user {this.name} {this.fathersName} {this.surName} Date of birth {birthDate.ToShortDateString()} age: {this.age()}";
        }       
        public User()
        {
            
        }

        public virtual void ConsoleCreate()
        {
            Console.WriteLine("Enter surname");
            this.surName = Console.ReadLine();
            Console.WriteLine("Enter name");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter fathers name");
            this.fathersName = Console.ReadLine();
            birthDate = SetBirthDay();            
        }
    }
}
