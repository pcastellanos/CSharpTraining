using ProjectB;

namespace CSharpTraining
{
    public class Worker : Person
    {
        public Worker(int age, string address, string name, string lastName) : base(address, lastName)
        {
            this.age = age;
            // this.Address = address;
            this.Name = name;
            //this.LastName = lastName;
        }

        public string Information()
        {
            return $"{this.Name} {this.MyAge()} {MyAddress()}"; 
        }
    }
}
