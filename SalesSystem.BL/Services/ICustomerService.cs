using SalesSystem.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.BL
{
    public interface ICustomerService
    {
        IEnumerable<Customer> Customers();
        Customer GetCustomer(int id);
        IEnumerable<Customer> FindCustomer(string searchCriteria);
    }
}
