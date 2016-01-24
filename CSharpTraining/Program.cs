using CSharpTraining.Sorting;
using Entities;
using System;
using System.Collections;

namespace CSharpTraining
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList products = GetSampleProducts();
            int size = products.Count;
            //you have to use one IComparer to compare just by one thing
            products.Sort(new ProductNameComparer());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(products[i]);
            }
            Console.Write("\n\n");

           
            Console.ReadLine();
        }

        private static ArrayList GetSampleProducts()
        {
            //Arraylist accept all kind of objects
            ArrayList list = new ArrayList();
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
