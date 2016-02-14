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

        private object[] values;
        private int startingPoint;

        public IterationSample(object[] values, int startingPoint)
        {
            this.values = values;
            this.startingPoint = startingPoint;
        }

        
        public IEnumerator GetEnumerator()
        {

            Console.WriteLine("Start of CreateEnumerable()");
            string value ="";
            for (int index = 0; index < values.Length; index++)
            {
                value = values[(index + startingPoint) % values.Length].ToString();
                Console.WriteLine("index {0} About to yield {1}", index, value);
                yield return value;
                Console.WriteLine("'{0}' After yield", value);
            }

            Console.WriteLine("'{0}' Yielding final value", value);
            yield return string.Empty;

            Console.WriteLine("End of GetEnumerator()");

        }

    }
}
