using Entities;
using System;
using System.Collections.Generic;

namespace CSharpTraining
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = GetSampleProducts();
           
            foreach(Product product in products)
            {
                //using extension methods
                Console.WriteLine(product.ToString() +" "+ product.TellAboutPrice());
            }
            Console.ReadLine();
        }

        private static List<Product> GetSampleProducts()
        {
            //Arraylist accept all kind of objects
            List<Product> list = new List<Product>();
            list.Add(new Product { Name = "West Side Story", Price = 9.99 });
            list.Add(new Product { Name = "Assassins", Price = 14.99 });
            list.Add(new Product { Name= "Frogs", Price =13.99 });
            list.Add(new Product { Name = "Sweeney Todd", Price = 10.99 });
            return list;
        }

    }
}
