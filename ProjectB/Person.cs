
namespace ProjectB
{
    public class Person
    {
        protected int age;
        public string Name { get; set; }
        internal string LastName { get; set; }

        private string Address { get; set; }

        public Person(string address, string lastName) 
        {
            this.Address = address;
            this.LastName = lastName;
        }

        public Person(string address)
        {
            Address = address;
        }

        internal string WhoAmI()
        {
            return $"{Name} {LastName}.";
        }

        protected string MyAge()
        {
            return $"My age is {age}";
        }

        protected internal string MyAddress()
        {
            return $"My address is {Address}";
        }
        public virtual string PublicMethod()
        {
            return "Hi";
        }
    }
}
