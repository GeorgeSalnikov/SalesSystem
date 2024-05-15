using System.Collections.Generic;
using SalesSystem.BL;
using SalesSystem.DAL;
using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.Web.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IBookService _service;
            
        public BookController(IBookService service)
            => _service = service;

        // GET: api/Book
        [HttpGet]
        public IEnumerable<Book> Get()
            => _service.Books();


        // GET: api/Book/Search/Girl
        [HttpGet("Search/{searchCriteria}", Name = "SearchBook")]
        public IEnumerable<Book> SearchBook(string searchCriteria)
            => _service.SearchBook(searchCriteria);

    }
}
