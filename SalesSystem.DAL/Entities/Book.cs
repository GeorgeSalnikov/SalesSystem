using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesSystem.DAL
{
    public class Book
    {
        public int Id { get; set; }
        
        public string ISBN { get; set; }

        //[MaxLength(50)]
        public string Title { get; set; }
        public string Author { get; set; }
        public BookFormat BookFormat { get; set; }
        public decimal ListPrice { get; set; }
    }
}
//'ControllerBase' is an ambiguous reference between 'Microsoft.AspNetCore.Mvc.ControllerBase' and 'System.Web.Mvc.ControllerBase'
    