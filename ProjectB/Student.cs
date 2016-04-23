using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    public class Student :Person
    {
        public Student(int age, string address, string name, string lastName) : base(address)
        {
            this.age = age;
            //this.Address = address;
            this.Name = name;
            this.LastName = lastName;
        }

        public string Information()
        {
            return $"{this.WhoAmI()} {this.MyAge()} {this.MyAddress()}";
        }
    }
}
