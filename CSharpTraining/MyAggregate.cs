using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class MyAggregate : IAggregate
    {
        List<string> values = null;

        public MyAggregate()
        {
            values = new List<string>();
        }

        public string this[int itemIndex]
        {
            get
            {
                return itemIndex < values.Count ? values[itemIndex] : string.Empty;
            }
            set
            {
                values.Add(value);
            }
        }

        public int Count
        {
            get
            {
                return values.Count;
            }
        }

        public IIterator GetIterator()
        {
            return new MyIterator(this);
        }
    }
}
