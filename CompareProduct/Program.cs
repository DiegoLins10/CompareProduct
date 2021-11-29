using CompareProduct.Entities;
using System;
using System.Collections.Generic;

namespace CompareProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900));
            list.Add(new Product("Celular", 1000));
            list.Add(new Product("Mouse", 200));

            list.Sort();

            foreach(var line in list)
            {
                Console.WriteLine(line);
            }
        }
    }
}
