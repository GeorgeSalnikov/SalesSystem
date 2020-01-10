using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BL
{
    public class UtilityService
    {
        private SalesSystemDbContext _context;

        public UtilityService(SalesSystemDbContext context)
            => _context = context;

        public void PopulateRepoWithTestData()
        {
            var bookFormatHardcover = new BookFormat { Format = "Hardcover", Description = "Book in hardcore" };
            var bookFormatPaperback = new BookFormat { Format = "Paperback", Description = "Book in paperback" };
            var bookFormaEbook = new BookFormat { Format = "Ebook", Description = "Kindle/Nook like book" };
            var bookFormatMassmarket = new BookFormat { Format = "Massmarket", Description = "Book for people on the busses" };
            var bookFormatDigitalAudio = new BookFormat { Format = "Digital Audio", Description = "Audio book for digitalplayers" };

            var book1 = new Book { ISBN = "9781400209606", Title = "Girl Stops Appologizing", Author = "Silva Daniel", BookFormat = bookFormatHardcover, ListPrice = 0.99M };
            var book2 = new Book { ISBN = "9780062834942", Title = "The other woman: a Novel", Author = "Cantor Jillian", BookFormat = bookFormatPaperback, ListPrice = 3.99M };
            var book3 = new Book { ISBN = "978006283434", Title = "Adventures of Huckelberry Finn", Author = "Mark Twain", BookFormat = bookFormatDigitalAudio, ListPrice = 4.59M };
            var book4 = new Book { ISBN = "978006283478", Title = "Invitation to Beheading", Author = "Vladimir Nabokov", BookFormat = bookFormatHardcover, ListPrice = 9.59M };
            var book5 = new Book { ISBN = "978006283409", Title = "War and Peace", Author = "Lev Tolstoy", BookFormat = bookFormatPaperback, ListPrice = 14.99M };

            var customer1 = new Customer { CustomerName = "Barnes & Nobles Distribution", AddressLine1 = "Barnes Noble", AddressLine2 = "Barnes Street", AddressLine3 = "Barnes Town" };
            var customer2 = new Customer { CustomerName = "Amazon.com,inc", AddressLine1 = "Amazing Amazon", AddressLine2 = "Amazon street", AddressLine3 = "Amazon City" };

            _context.AddRange(new[] { book1, book2 });
            _context.AddRange(new[] { customer1, customer1 });
            _context.AddRange(new[]
            {
                new Order {Customer = customer1, Book = book1, Qty = 100 },
                new Order {Customer = customer2, Book = book1, Qty = 200 },
                new Order {Customer = customer1, Book = book2, Qty = 300 },
                new Order {Customer = customer2, Book = book2, Qty = 400 },
                new Order {Customer = customer1, Book = book3, Qty = 500 },
                new Order {Customer = customer2, Book = book3, Qty = 600 },
                new Order {Customer = customer1, Book = book4, Qty = 700 },
                new Order {Customer = customer2, Book = book4, Qty = 800 },
                new Order {Customer = customer1, Book = book5, Qty = 900 },
                new Order {Customer = customer2, Book = book5, Qty = 1000 },
            });

            int numChanges = _context.SaveChanges();
        }
    }
}
