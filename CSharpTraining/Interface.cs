using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    interface IExample
    {
        int this[string index] { get; set; }
      
        int Value { get;  }
        event EventHandler ResultRetrieved;
        string GetResult();

    }

}
