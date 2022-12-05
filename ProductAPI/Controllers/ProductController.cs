using Microsoft.AspNetCore.Mvc;
using ProductAPI.Abstractions;
using ProductAPI.Model;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public ProductController(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IEnumerable<Laptop> Get()
        {
            return _applicationDbContext.Laptops;
        }
    }
}