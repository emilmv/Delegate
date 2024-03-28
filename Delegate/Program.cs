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
            List<Book> books = new List<Book>();
            books.Add(new Book { Name = "Yeddi Gozel", AuthorName = "Nizami Gencevi", PageCount = 500 });
            books.Add(new Book { Name = "Leyli ve Mecnun", AuthorName = "Nizami Gencevi", PageCount = 600 });
            books.Add(new Book { Name = "Ferhad ve Shirin", AuthorName = "Nizami Gencevi", PageCount = 700 });
            books.Add(new Book { Name = "Cay Desgahi", AuthorName = "Celil Memmedquluzade", PageCount = 300 });
            books.Add(new Book { Name = "Oluler", AuthorName = "Celil Memmedquluzade", PageCount = 400 });
            books.Add(new Book { Name = "Cinayet ve Ceza", AuthorName = "Fyodor Dostoyevski", PageCount = 600 });
            Predicate<Book> BooksOfNizami = b => b.AuthorName.ToUpper() == "NIZAMI GENCEVI";
            var result=books.FindAll(BooksOfNizami);
            foreach(Book book in result)
            {
                Console.WriteLine(book);
            }
            #endregion
        }
    }
}
