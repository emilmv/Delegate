using Delegate.Entities;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            List<Person> list = new List<Person>();
            list.Add(new Person { Name = "Marcus", SurName = "Rashford", Address = "United Kingdom", Salary = 1000000 });
            list.Add(new Person { Name = "Anthony", SurName = "Martial", Address = "France", Salary = 1200000 });
            list.Add(new Person { Name = "Luke", SurName = "Shaw", Address = "United Kingdom", Salary = 500 });
            Predicate<Person> Filter = p => p.Salary > 1000;
            var result = list.FindAll(Filter);
            foreach (Person p in result)
            {
                Console.WriteLine(p);
            }
            #endregion
        }
    }
}
