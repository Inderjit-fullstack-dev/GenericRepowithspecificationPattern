using GenericRepositoryWithSpecificationExample.Core.Models;
using GenericRepositoryWithSpecificationExample.Infrastructure.GenericRepo;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryWithSpecificationExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepository<Product> _productRepository;

        public ProductsController(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _productRepository.GetAll();
            return Ok(result);
        }
    }
}
