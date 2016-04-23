using System;

namespace CSharpTraining
{
    class ExampleImplementation : IExample
    {
        public int this[string index]
        {
            get
            {
                return 42;
            }

            set
            { 
            }
        }

        public int Value
        {
            get;
            set;
        }

        public event EventHandler ResultRetrieved;

        public string GetResult()
        {
            return "result";
        }
    }
}

