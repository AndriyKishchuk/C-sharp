namespace Projekt_13
{
    internal class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public int Price { get; set; }

        public bool IsDeleted { get; set; }
        public Categories Categories { get; set; }
        public int CategoriesId { get; set; }

        protected Book() { }

        public Book(int id, string? title, int price)
        {
            Id = id;
            Title = title;
            Price = price;
        }
    }
}
