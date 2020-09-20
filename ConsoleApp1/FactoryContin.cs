using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Factory
    {
        public decimal AvgSalary
        {
            get
            {
                decimal count = 0;
                for (int i = 0; i < employees.Length; i++)
                {
                    count += employees[i].Salary;
                }
                return count /= employees.Length;
            }
        }

        public decimal TotalSalary
        {
            get
            {
                decimal count = 0;
                for (int i = 0; i < employees.Length; i++)
                {
                    count += employees[i].Salary;
                }
                return count;
            }
        }

        public decimal GDP
        {
            get
            {
                decimal count = 0;
                for (int i = 0; i < products.Length; i++)
                {
                    count += products[i].Price;
                }
                return count /= employees.Length;
            }
        }

        public int EmpCount
        {
            get
            {
                return employees.Length;
            }
        }
    }
}
