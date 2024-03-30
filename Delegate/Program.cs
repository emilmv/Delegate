using Delegate.Entities;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //List<Person> Persons = new List<Person>();
            //Persons.Add(new Person { Name = "Marcus", SurName = "Rashford", Address = "United Kingdom", Salary = 1000000 });
            //Persons.Add(new Person { Name = "Anthony", SurName = "Martial", Address = "France", Salary = 1200000 });
            //Persons.Add(new Person { Name = "Luke", SurName = "Shaw", Address = "United Kingdom", Salary = 500 });
            //foreach (var item in CalculateSalary(p => p.Salary > 1000, Persons))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Task2
            //List<Book> books = new List<Book>();
            //books.Add(new Book { Name = "Yeddi Gozel", AuthorName = "Nizami Gencevi", PageCount = 500 });
            //books.Add(new Book { Name = "Leyli ve Mecnun", AuthorName = "Nizami Gencevi", PageCount = 600 });
            //books.Add(new Book { Name = "Ferhad ve Shirin", AuthorName = "Nizami Gencevi", PageCount = 700 });
            //books.Add(new Book { Name = "Cay Desgahi", AuthorName = "Celil Memmedquluzade", PageCount = 300 });
            //books.Add(new Book { Name = "Oluler", AuthorName = "Celil Memmedquluzade", PageCount = 400 });
            //books.Add(new Book { Name = "Cinayet ve Ceza", AuthorName = "Fyodor Dostoyevski", PageCount = 600 });
            //Console.WriteLine(CountOfNizamiBooks(b=>b.AuthorName.Equals("nizami gencevi",StringComparison.OrdinalIgnoreCase),books));
            #endregion
            #region Task3
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Name = "Marcus", Age = 25, Salary = 2500 });
            employees.Add(new Employee { Name = "Anthony", Age = 30, Salary = 1500 });
            employees.Add(new Employee { Name = "Luke", Age = 22, Salary = 600 });
            var newList = employees.FindAll(e => e.Age > 20 && e.Age < 40);
            Console.WriteLine("Sum of Salary: "+newList.Sum(e=>e.Salary));
            Console.WriteLine("Max Salary: "+newList.Max(e=>e.Salary));
            Console.WriteLine("Min Salary: "+newList.Min(e=>e.Salary));
            Console.WriteLine("Average Salary: "+newList.Average(e=>e.Salary));
            #endregion
        }
        static List<Person> CalculateSalary(Predicate<Person> method, List<Person> list)
        {
            return list.FindAll(method);
        }
        static int CountOfNizamiBooks(Predicate<Book> method, List<Book> list)
        {
            return list.FindAll(method).Count;
        }
    }
}
