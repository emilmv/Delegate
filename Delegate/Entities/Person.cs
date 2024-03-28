namespace Delegate.Entities
{
    internal class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Full Name: {Name} {SurName} , Address: {Address}, Salary: {Salary}";
        }
    }
}
