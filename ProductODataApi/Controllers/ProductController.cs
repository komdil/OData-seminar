using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ProductAPI.Abstractions;
using ProductAPI.Model;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ODataController
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public ProductController(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [EnableQuery]
        [HttpGet]
        public IEnumerable<Laptop> Get()
        {
            return _applicationDbContext.Laptops;
        }
    }
}