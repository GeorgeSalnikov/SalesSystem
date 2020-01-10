using System.Collections.Generic;
using SalesSystem.BL;
using SalesSystem.DAL;
using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _service;

        public CustomerController(ICustomerService service)
            => _service = service;

        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
            => _service.Customers();

        [HttpGet("{id}", Name = "Get")]
        public Customer Get([FromRoute] int id)
        {
            var cust = _service.GetCustomer(id);
            return cust;
        }
 
        [HttpDelete("{id}", Name = "Delete")]
        public Customer Delete([FromRoute] int id)
        {
            var cust = _service.GetCustomer(id);
            return cust;
        }
    }
}
