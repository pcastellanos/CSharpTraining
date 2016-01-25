using Entities;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpTraining
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Bill> bills = JsonConvert.DeserializeObject<List<Bill>>(JSON.Bills);

       
        }

    }
}
