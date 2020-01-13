using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesSystem.BL;
using SalesSystem.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.Web.Controllers
{
    [Route("api/Order")]
    //[ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _service;

        public OrderController(IOrderService service)
            => _service = service;


        // DELETE: api/Order/Delete/id

        /// <summary>GS. Nowadays people do not hard-delete, but soft-delete (mark record as inactive/deleted, and som)
        /// </summary>
        /// <param name="orderId"></param>
        [HttpGet("Delete/{id}")]
        public Customer Delete(int id)
            => _service.DeleteOrder(id);
    }
}
