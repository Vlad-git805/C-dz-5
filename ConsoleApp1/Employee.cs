using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate;
        public decimal Salary { get; set; }

        public Employee()
        {
            Name = "";
            SurName = "";
            Salary = 0;
        }

        public Employee(string name, string SurName, DateTime BirthDay, decimal salary)
        {
            Name = name;
            this.SurName = SurName;
            this.BirthDate = BirthDay;
            Salary = salary;
        }

        public override string ToString()
        {
            return ($"Name: {Name}\n" +
                $"Surname: {SurName}\n" +
                $"Birht date: {BirthDate}\n" +
                $"Salary: {Salary}\n");
        }
    }
}
