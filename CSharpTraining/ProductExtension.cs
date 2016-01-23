using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public static class ProductExtension
    {
        public static string TellAboutPrice(this Product product)
        {
            return product.Price > 10 ? "Expensive" : "Cheap";
        }
    }
}
