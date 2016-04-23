using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    internal class Student :Person, Interface1
    {
        public Student(int age, string address, string name, string lastName) : base(address)
        {
            this.age = age;
            //this.Address = address;
            this.Name = name;
            this.LastName = lastName;
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }

        public string Information()
        {
            return $"{this.WhoAmI()} {this.MyAge()} {this.MyAddress()}";
        }

        public override string PublicMethod()
        {
            return "Hi Student";
        }
    }
}
