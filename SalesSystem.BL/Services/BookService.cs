using SalesSystem.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.BL
{
    public class BookService : IBookService
    {
        private readonly SalesSystemDbContext _context;

        public BookService(SalesSystemDbContext context)
            => _context = context;

        public IEnumerable<Book> Books()
            => _context.Books;

        public IEnumerable<Book> SearchBook(string searchCriteria)
            => _context.Books.Where(b => b.Title.Contains(searchCriteria) || b.Author.Contains(searchCriteria) || b.ISBN.Contains(searchCriteria));

        public Book GetBook(int id)
            => _context.Books.FirstOrDefault(b => b.Id == id);
    }
}
