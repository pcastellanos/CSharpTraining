using CSharpTraining.Sorting;
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
            int size = products.Count;

            //IComparer strongly type
            //products.Sort(new ProductNameComparer());

            //using delegate and avoiding extra class
            products.Sort(delegate (Product first, Product second)
            {
                return first.Name.CompareTo(second.Name);
            });

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(products[i]);
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
