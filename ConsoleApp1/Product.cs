using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Product
    {
        public enum CategoruType
        {
            MealkProductType = 1, MeatProductType, NonProductType = 3
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public CategoruType Category { get; set; }
        public readonly DateTime ManufactureDate;

        public Product(string name, decimal price, DateTime datetime, int category)
        {
            Name = name;
            Price = price;
            Category = (CategoruType)category;
            ManufactureDate = datetime;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Price: {Price}\n " +
                $"Category: {Category}\n"; 
        }
    }
}
