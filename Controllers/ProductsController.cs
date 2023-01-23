using GenericRepositoryWithSpecificationExample.Core.Models;
using GenericRepositoryWithSpecificationExample.Core.SpecQueries;
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
        public IActionResult GetAllProducts()
        {
            var specification = new GetProductsWithCategorySpecification();
            var result = _productRepository.FindWithSpecificationPattern(specification);
            return Ok(result);
        }
    }
}
