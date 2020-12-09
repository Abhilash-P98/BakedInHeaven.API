using BakedInHeaven.BusinessServices;
using BakedInHeaven.BusinessServices.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakedInHeaven.API.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;
        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }
        [HttpGet]
        public IEnumerable<ProductDto> GetAllProducts()
        {

            return _productsService.GetAllProducts();
        }
        [HttpPost]
        public void AddProduct(ProductDto product)
        {
            _productsService.AddProduct(product);
        }
        [HttpDelete]
        public void DeleteProduct(ProductDto product)
        {
            _productsService.DeleteProduct(product);
        }
        [HttpPut]
        public void UpdateProduct(ProductDto product)
        {
            _productsService.UpdateProduct(product);
        }
    }
}
