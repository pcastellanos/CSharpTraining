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
            ArrayList products = GetSampleProducts();

            foreach (Product product in products)
            {
                if (product.Price >= 10)
                    Console.WriteLine(product);
            }
            Console.Write("\n\n");
            
            Console.ReadLine();
        }

        private static ArrayList GetSampleProducts()
        {
            //Arraylist accept all kind of objects
            ArrayList list = new ArrayList();
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
