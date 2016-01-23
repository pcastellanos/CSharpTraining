using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Models
{
    public class Product
    {
        string name;

        //public get and private set
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        double price;

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
