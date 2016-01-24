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

            dynamic dyn = 1;
            object obj = 1; 
            dyn = dyn + 3;
            //obj = obj + 3;
            
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(obj.GetType());

            dynamic products = GetSampleProducts();

            foreach(dynamic product in products)
            {
                Console.WriteLine(product.ToString());
                //Console.WriteLine(product.LoQuesea);
            }



            Console.ReadLine();
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
