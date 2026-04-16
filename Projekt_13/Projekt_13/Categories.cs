namespace Projekt_13
{
    internal class Categories
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }

        public List<Book> Book { get; set; }


        protected Categories() { }

        public Categories(int id, string? categoryName)
        {
            Id = id;
            CategoryName = categoryName;
            Book = new List<Book>();
        }
    }
}
