using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Supplier
    {
        public Supplier(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
    