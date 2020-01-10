using Microsoft.EntityFrameworkCore;
using SalesSystem.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SalesSystem.BL
{
    public class OrderService : IOrderService
    {
        private readonly SalesSystemDbContext _context;

        public OrderService(SalesSystemDbContext context)
            => _context = context;

        public Customer DeleteOrder(int id)
        {
            var order = _context.Orders.Include(o => o.Customer).First(o => o.Id == id)    //c => c.Orders.SelectMany(o => o.Book ))
                ;
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return _context.Customers
                .Include("Orders.Book")    //c => c.Orders.SelectMany(o => o.Book ))
                .Include("Orders.Book.BookFormat")    //c => c.Orders.SelectMany(o => o.Book ))
                .FirstOrDefault(cu => cu.Id == order.Customer.Id)
                ;

        }

        public IEnumerable<Order> GetCustomerOrders(int customerId)
            =>  throw new System.NotImplementedException();
    }
}
