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
            Action<Product> write = Console.WriteLine;

            //Using lambda expression
            Console.WriteLine("Products with unknown price");
            products.FindAll(delegate (Product p) { return !p.Price.HasValue; }).ForEach(write);
            Console.Write("\n\n");
            Console.WriteLine("Products with known price");
            products.FindAll(product => product.Price.HasValue && product.Price > 10).ForEach(write);
            Console.Write("\n\n");
            Console.ReadLine();
        }

        private static List<Product> GetSampleProducts()
        {
            //Arraylist accept all kind of objects
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story 2", 13.76));
            list.Add(new Product("West Side Story"));
            list.Add(new Product("Frogs"));
            list.Add(new Product("Assassins", 14.99));
            list.Add(new Product("Assassins 2"));
            list.Add(new Product("Sweeney Todd", 10.99));
            list.Add(new Product("Sweeney Todd"));
            return list;
        }

    }
}
