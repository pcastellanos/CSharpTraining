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

        //public getter properties,then public setter too
        public string Name { get { return name; } set { name = value; } }

        double price;

        public double Price { get { return price; } }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
