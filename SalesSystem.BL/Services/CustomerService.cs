using Microsoft.EntityFrameworkCore;
using SalesSystem.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.BL
{
    public class CustomerService : ICustomerService
    {
        private readonly SalesSystemDbContext _context;

        public CustomerService(SalesSystemDbContext context)
            => _context = context;

        public IEnumerable<Customer> Customers()
            => _context.Customers;//.Select(ev => new Event { Id = ev.Id, Title = ev.Title, Description = ev.Description, Date = ev.Date, Type = new EventType { Id = ev.Type.Id, Title = ev.Type.Title, } });

        public IEnumerable<Customer> FindCustomer(string searchCriteria)
            => _context.Customers
            .Where(cu => cu.CustomerName.Contains(searchCriteria) || cu.Id.ToString().Contains(searchCriteria))
            .Include(c => c.Orders)
            ;

        public Customer GetCustomer(int id)
            => _context.Customers
            .Include("Orders.Book")    //c => c.Orders.SelectMany(o => o.Book ))
            .Include("Orders.Book.BookFormat")    //c => c.Orders.SelectMany(o => o.Book ))
            .FirstOrDefault(cu => cu.Id == id)
            ;
    }
}
