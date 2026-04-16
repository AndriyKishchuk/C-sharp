using Microsoft.EntityFrameworkCore;

namespace Projekt_13
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AplicationContext();

            Console.WriteLine("Завдання 1: Книги > 300грн ");
            var expensiveBooks = await context.Books
                .Where(b => b.Price > 300)
                .OrderByDescending(b => b.Price)
                .Select(b => new { b.Title, b.Price })
                .ToListAsync();

            foreach (var book in expensiveBooks)
            {
                Console.WriteLine($"Назва: {book.Title}, Ціна: {book.Price} грн");
            }

            Console.WriteLine("\nЗавдання 2: Додаваня даних");
            var newCategory = new Categories(0, "Програмування");
            await context.Categories.AddAsync(newCategory);
            await context.SaveChangesAsync();

            var cleanCode = new Book(0, "Clean Code", 600)
            {
                CategoriesId = newCategory.Id
            };
            await context.Books.AddAsync(cleanCode);
            await context.SaveChangesAsync();
            Console.WriteLine($"Додано категорію: {newCategory.CategoryName}");

            Console.WriteLine("\nЗавдання 3:Оновлення ціни");
            var newPrice = await context.Books.FirstOrDefaultAsync(b => b.Title == "Clean Code");
            if (newPrice != null)
            {
                newPrice.Price = 750;
                await context.SaveChangesAsync();
                Console.WriteLine($"Оновлено ціну книги 'Clean Code' до {newPrice.Price} грн");
            }

            Console.WriteLine("\nЗавдання 4: Єднання книг");
            var booksWithCategories = await context.Books
                .Include(b => b.Categories)
                .Where(b => b.Categories != null)
                .Select(b => new { b.Title, b.Categories.CategoryName })
                .ToListAsync();

            foreach (var book in booksWithCategories)
            {
                Console.WriteLine($"Назва: {book.Title}, Категорія: {book.CategoryName}");
            }

            Console.WriteLine("\nЗавдання 5: Group By");
            var groupped = await context.Books
                .GroupBy(b => b.CategoriesId)
                .Select(g => new { Category = g.Key, TotalBooks = g.Count() })
                .ToListAsync();

            foreach (var group in groupped)
            {
                Console.WriteLine($"Категорія ID: {group.Category}, Кількість книг: {group.TotalBooks}");
            }

            Console.WriteLine("\nЗавдання 6: Видалення книги(SoftDelete)");
            var bookToDelete = await context.Books.FirstOrDefaultAsync(b => b.Id == 1);
            if (bookToDelete != null)
            {
                bookToDelete.IsDeleted = true;
                await context.SaveChangesAsync();
                Console.WriteLine($"Книга з ID {bookToDelete.Id} позначена як видалена.");
            }
            else
            {
                Console.WriteLine("Книга з ID 5 не знайдена.");
            }
        }
    }
}