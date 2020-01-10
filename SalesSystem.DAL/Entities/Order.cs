using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.DAL
{
    public class Order
    {
        public int Id { get; set; }

        public int Qty { get; set; }

        public Customer Customer { get; set; }
        public Book Book { get; set; }
    }
}
