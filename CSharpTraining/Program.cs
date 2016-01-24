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

            //lambda expression. Implicit type (first, second)
            //products.Sort((first, second) => first.Name.CompareTo(second.Name));
            products.Sort((first, second) => first.Price.CompareTo(second.Price));

            foreach (Product product in products)
            {
                Console.WriteLine(product + " is " + product.TellAboutPrice());
            }
            Console.Write("\n\n");
            
            Console.ReadLine();
        }

        private static List<Product> GetSampleProducts()
        {
            //Arraylist accept all kind of objects
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story", 9.99));
            list.Add(new Product("Assassins", 14.99));
            list.Add(new Product("Frogs", 13.99));
            list.Add(new Product("Sweeney Todd", 10.99));
            //list.Add("Adición de un texto normal");
            //list.Add(12432424);
            return list;
        }

    }
}
