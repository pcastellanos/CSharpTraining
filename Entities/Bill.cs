using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bill
    {
        public DateTime CreationDate { get; set; }
        public int Id { get; set; }
        public string ClientName { get; set; }

        public List<Product> Products { get; set; }
        
        public double? Total { get; set; }
    }
}
