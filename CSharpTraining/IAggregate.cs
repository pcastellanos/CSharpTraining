using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public interface IAggregate
    {
        IIterator GetIterator();
        string this[int itemIndex] { set; get; }
        int Count { get; }
    }
}
