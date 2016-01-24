using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTraining
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = GetSampleProducts();
            List<Supplier> suppliers = GetSampleSuppliers();

            var filtered = from p in products
                           join s in suppliers
                           on p.IdSupplier equals s.Id
                           where p.Price > 10
                           orderby s.Name, p.Name
                           select new { SupplierName = s.Name, ProductName = p.Name, IdSupplier = s.Id }; //Anonymous type

            foreach (var result in filtered)
            {
                Console.WriteLine("Supplier={0}; Product={1} idSupplier= {2}",
                result.SupplierName, result.ProductName, result.IdSupplier);
            }
            
            Console.ReadLine();
        }

        private static List<Supplier> GetSampleSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            suppliers.Add(new Supplier("Solely Sondheim", 1));
            suppliers.Add(new Supplier("CD-by-CD-by-Sondheim", 2));
            suppliers.Add(new Supplier("Barbershop CDs", 3));

            return suppliers;

        }

        private static List<Product> GetSampleProducts()
        {
            //Arraylist accept all kind of objects
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story 2", 1, 13.76));
            list.Add(new Product("West Side Story", 1, 9.99));
            list.Add(new Product("Frogs",2));
            list.Add(new Product("Assassins",1, 14.99));
            list.Add(new Product("Assassins 2",2, 12.78));
            list.Add(new Product("Sweeney Todd",3, 10.99));
            list.Add(new Product("Sweeney Todd 2",1, 5.87));
            return list;
        }

    }
}
