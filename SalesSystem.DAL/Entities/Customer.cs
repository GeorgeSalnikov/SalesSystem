using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesSystem.DAL
{
    public class Customer
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        public List<Order> Orders { get; set; }
    }
}
