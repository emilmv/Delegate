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
            //Predicate<Person> Filter = p => p.Salary > 1000;
            //var result = Persons.FindAll(Filter);
            //foreach (Person p in result)
            //{
            //    Console.WriteLine(p);
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
            //Predicate<Book> BooksOfNizami = b => b.AuthorName.ToUpper() == "NIZAMI GENCEVI";
            //var result=books.FindAll(BooksOfNizami);
            //foreach(Book book in result)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion
            #region Task3
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Name = "Marcus", Age = 25, Salary = 2500 });
            employees.Add(new Employee { Name = "Anthony", Age = 30, Salary = 1500 });
            employees.Add(new Employee { Name = "Luke", Age = 22, Salary = 600 });
            Calculate calculate= Sum;
            calculate += Avg;
            calculate += Min;
            calculate += Max;
            #endregion
        }
        public delegate double Calculate(List<Employee>employees);

        static double Sum(List<Employee>employees)
        {
            double sum = 0;
            foreach (Employee employee in employees)
            {
                sum += employee.Salary;
            }
            return sum;
        }
        static double Avg(List<Employee> employees)
        {
            return Sum(employees) / employees.Count;
        }
        static double Min(List<Employee> employees)
        {
            var result= employees.Find(e => e.Salary == employees.Min(employees => employees.Salary));
            return result.Salary;
        }
        static double Max(List<Employee> employees)
        {
            var result = employees.Find(e => e.Salary == employees.Max(employees => employees.Salary));
            return result.Salary;
        }
    }
}
