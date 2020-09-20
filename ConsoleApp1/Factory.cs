using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Factory
    {
        public string Name { get; set; }
        public Employee[] employees;
        public Product[] products;

        public Factory()
        {
            Name = "no name";
            employees = null;
            products = null;
        }

        public void Menu_for_creating_factory()
        {
            int num1 = 0;
            string Name = null;
            string SurName = null;
            DateTime Date_of_mannufacture;
            decimal Salary = 0;
            Console.Write("enter name Factory:");
            Name = Console.ReadLine();

            this.Name = Name;

            Console.Write("enter the number employee:");
            num1 = int.Parse(Console.ReadLine());
            employees = new Employee[num1];
            for (int i = 0; i < num1; i++)
            {
                Console.Write((i + 1) + ":enter Name employee:");
                Name = Console.ReadLine();
                Console.Write((i + 1) + ":enter SurName employee:");
                SurName = Console.ReadLine();
                Console.Write((i + 1) + ":enter Salary employee:");
                Salary = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter year of birthday employee:");
                int year = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter month of birthday employee:");
                int month = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter day of birthday employee:");
                int day = int.Parse(Console.ReadLine());
                Date_of_mannufacture = new DateTime(year, month, day);

                employees[i] = new Employee(Name, SurName, Date_of_mannufacture, Salary);
                Console.WriteLine();
            }
            decimal Prise = 0;
            int type = 0;
            Console.Write("enter the number products:");
            num1 = int.Parse(Console.ReadLine());
            products = new Product[num1];
            for (int i = 0; i < num1; i++)
            {
                Console.Write((i + 1) + ":enter Name products:");
                Name = Console.ReadLine();
                Console.Write((i + 1) + ":enter Prise products:");
                Prise = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter type products:\n");
                Console.WriteLine(" 1-MealkProductType\n 2-MeatProductType\n 3-NonProductType");
                type = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter year of graduation products:");
                int year = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter month of issue products:");
                int month = int.Parse(Console.ReadLine());
                Console.Write((i + 1) + ":enter day of issue products: ");
                int day = int.Parse(Console.ReadLine());
                Date_of_mannufacture = new DateTime(year, month, day);
                products[i] = new Product(Name, Prise, Date_of_mannufacture, type);
                Console.WriteLine();
            }
        }

        public void Show_info_employees()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].ToString();
            }
        }

        public void Show_info_productss()
        {
            for (int i = 0; i < products.Length; i++)
            {
                products.ToString();
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"WorcerCount: {EmpCount}\n";
        }

    }
}
