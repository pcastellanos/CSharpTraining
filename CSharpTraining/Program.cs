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
            ArrayList products = GetSampleProducts();
            int size = products.Count;
            for(int i=0; i<size; i++)
            {
                Console.WriteLine(products[i].ToString());
            }
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
