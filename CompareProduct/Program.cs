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

            /*
             * usando lambda para criar um metodo delagate comparison
             */
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //list.Sort(CompareProducts);
            list.Sort(comp);

            foreach(var line in list)
            {
                Console.WriteLine(line);
            }
        }

        static int CompareProducts(Product p1 , Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
