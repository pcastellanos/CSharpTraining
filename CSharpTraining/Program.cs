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

            Printer(number: 25, text: "Paula");
            Console.ReadLine();
        }

        private static void Printer (string text, int number)
        {
            Console.WriteLine(text + " " + number);
        }

        private static List<Product> GetSampleProducts()
        {
            //Arraylist accept all kind of objects
            List<Product> list = new List<Product>();
            list.Add(new Product(price : 9.99, name: "West Side Story"));
            list.Add(new Product ( name : "Assassins", price : 14.99 ));
            list.Add(new Product(price: 13.99, name : "Frogs"));
            list.Add(new Product (name:"Sweeney Todd", price: 10.99 ));
            return list;
        }

    }
}
