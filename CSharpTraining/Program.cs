using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace CSharpTraining
{
    class Program
    {
        public static void Main(string[] args)
        {
            XDocument doc = XDocument.Load(@"..\..\File\Data.xml");
            var filtered = from p in doc.Descendants("Product")
                           join s in doc.Descendants("Supplier")
                           on (int)p.Attribute("SupplierID")
                           equals (int)s.Attribute("SupplierID")
                           where (decimal)p.Attribute("Price") > 10
                           orderby (string)s.Attribute("Name"),
                           (string)p.Attribute("Name")
                           select new
                           {
                               SupplierName = (string)s.Attribute("Name"),
                               ProductName = (string)p.Attribute("Name"),
                               IdSupplier = (int)s.Attribute("SupplierID")
                           };
            

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
