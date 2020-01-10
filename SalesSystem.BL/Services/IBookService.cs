using SalesSystem.DAL;
using System.Collections.Generic;

namespace SalesSystem.BL
{
    public interface IBookService
    {
        IEnumerable<Book> Books();
        IEnumerable<Book> FindBook(string searchCriteria);
        Book GetBook(int id);
    }
}