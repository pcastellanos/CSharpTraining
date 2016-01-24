using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {

        //Simplify get and set
        public string Name
        {
            get;
            set;
        }

        double? price;

        public double? Price
        {
            get { return price; }
            set { price = value; }
        }

        public int IdSupplier { get; set; }
        public Product (string name, int supplierId, double? price=null) //Optional parameter has to be at the end
        {
            Name = name;
            Price = price;
            IdSupplier = supplierId;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
