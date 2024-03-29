﻿using EntityFremwork_firs.Applications.ProductService;
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
        public Task<string> AddProduct(Product product)
        {
            
            return _productService.CreateProductAsync(product);
        }

        [HttpGet]
        public Task<List<Product>> GetProduct()
        {

            return _productService.GetAllProductAsync(); 
        }

        [HttpPut]
        public Task<string> UpdateProduct(int id, Product product)
        {

            return _productService.UpdateProductAsync(id, product);
        }
        [HttpDelete]
        public Task<bool> DeleteProduct(int id)
        {
            return _productService.DeleteProductAsync(id);
        }
    }
}
