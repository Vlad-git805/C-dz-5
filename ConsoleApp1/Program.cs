using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.Menu_for_creating_factory();
            factory.Show_info_employees();
            factory.Show_info_productss();
            Console.WriteLine(" AvgSalary: " + factory.AvgSalary);
            Console.WriteLine(" TotalSalery: " + factory.TotalSalary);
            Console.WriteLine(" factory.GDP:" + factory.GDP);
            Console.WriteLine(" WorkersCount:" + factory.EmpCount);
        }
    }
}
