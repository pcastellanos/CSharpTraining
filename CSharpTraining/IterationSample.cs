using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class IterationSample : IEnumerable
    {

       public object[] Values { get; set; }
        public int StartingPoint { get; set; }

        public IterationSample(object[] values, int startingPoint)
        {
            this.Values = values;
            this.StartingPoint = startingPoint;
        }
        
        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
            return new IterationSampleIterator(this);
        }
    }
}
