using EntityFremwork_firs.Applications.ProductService;
using EntityFremwork_firs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFremwork_firs.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public string AddProduct(Product product)
        {
            _productService.CreateProductAsync(product);
            return "yaratildi";
        }
    }
}
