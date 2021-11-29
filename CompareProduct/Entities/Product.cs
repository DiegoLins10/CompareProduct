using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace CompareProduct.Entities
{
    class Product  
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Price: " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
        /*
         * Interface compareTo que ordena pelo nome
         */
     //   public int CompareTo(Product other)
     //   {
     //       return Name.ToUpper().CompareTo(other.Name.ToUpper());
     //   }
    }
}
