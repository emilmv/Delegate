namespace Delegate.Entities
{
    internal class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public override string ToString()
        {
            return $"Book Name: {Name}, Author Name: {AuthorName} , Page Count: {PageCount}";
        }
    }
}
