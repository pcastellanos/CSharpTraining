using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.Sorting
{
    public class ProductNameComparer : IComparer<Product>
    {
        public int Compare(Product first, Product second)
        {
            return first.Name.CompareTo(second.Name);
        }
    }
}
