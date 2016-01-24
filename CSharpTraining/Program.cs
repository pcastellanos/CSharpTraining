using Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpTraining
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = GetSampleProducts();

            Predicate<Product> test = delegate (Product p) { return p.Price > 10; };
            List<Product> matches = products.FindAll(test);
            Action<Product> print = Console.WriteLine; //method group conversions that makes it easier to create delegates from existing methods.
            matches.ForEach(print);

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
