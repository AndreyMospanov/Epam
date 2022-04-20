using System;
using  _2._3_User;

/*2.5. EMPLOYEE
На основе класса User (см. задание 2.3) создать класс Employee, описывающий сотрудника
фирмы. Дополнить класс свойствами «стаж работы» и «должность». Обеспечить нахождение
класса в заведомо корректном состоянии.*/

namespace _2._5_Employee
{
    class Employee : User
    {
        private int _expirience;
        private string _position;

        public string Position { get => _position; set => _position = value; }
        public int Expirience { get => _expirience; set => _expirience = value; }
        public int CalculateExpirience(int start)
        {
            return DateTime.Now.Year - start;
        }
        public Employee() 
        {
            Console.WriteLine("Enter position");
            Position = Console.ReadLine();
            int start = 0;
            try
            {
                Console.WriteLine("Enter year of job start");
                int.TryParse(Console.ReadLine(), out start);
                if(start < 1960)
                {                    
                    throw new Exception();
                }
            }
            catch(Exception) when (start < 1960)
            {
                Console.WriteLine("may be you print wrong date");
            }
            catch (Exception)
            {
                throw;
            }
            Expirience = CalculateExpirience(start);
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        { 
            if(Position != null)
            {
                return $"You've created new Employee {this.name} {this.fathersName} {this.surName} Date of birth {birthDate.ToShortDateString()} age: {this.age()} position {this.Position}, expirience {this.Expirience} years";
            }
            else
            {                
                return "";
            }  
        }
    }
} 

