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
            products.FindAll(product => product.Price > 10).ForEach(write);
            Console.Write("\n\n");
            Console.ReadLine();
        }

        private static List<Product> GetSampleProducts()
        {
            //Arraylist accept all kind of objects
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story 2", 13.76));
            list.Add(new Product("West Side Story", 9.99));
            list.Add(new Product("Frogs", 13.99));
            list.Add(new Product("Assassins", 14.99));
            list.Add(new Product("Assassins 2", 24.23));
            list.Add(new Product("Sweeney Todd", 10.99));
            list.Add(new Product("Sweeney Todd", 5.99));
            return list;
        }

    }
}
