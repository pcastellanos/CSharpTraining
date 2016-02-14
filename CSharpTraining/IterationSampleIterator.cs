using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class IterationSampleIterator : IEnumerator
    {
        IterationSample parent;
        int position;

        internal IterationSampleIterator(IterationSample parent)
        {
            this.parent = parent;
            position = -1;
        }

        public bool MoveNext()
        {
            if (position != parent.Values.Length)
            {
                position++;
            }
            return position < parent.Values.Length;
        }

        public object Current
        {
            get
            {
                if (position == -1 ||
                    position == parent.Values.Length)
                {
                    throw new InvalidOperationException();
                }
                int index = (position + parent.StartingPoint);
                index = index % parent.Values.Length;
                return parent.Values[index];
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
