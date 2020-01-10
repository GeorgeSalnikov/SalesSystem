using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BL
{
    public interface IOrderService
    {
        IEnumerable<Order> GetCustomerOrders(int customerId);
        Customer DeleteOrder(int id);
    }
}
