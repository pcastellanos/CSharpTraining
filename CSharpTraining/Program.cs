using CSharpTraining.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = GetSampleProducts();
           
            foreach(Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
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
            
            return list;
        }

    }
}
