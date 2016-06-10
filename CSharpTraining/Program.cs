
using CSharpTraining.WorkFlowEngine;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {
            WorkflowEngineSOASoap engine = new WorkflowEngineSOASoapClient();
            engine.abortCasesAsString(Resource.xml);
            Console.WriteLine("Aborted"); 
            Console.ReadLine();
        }

   
    }
}


