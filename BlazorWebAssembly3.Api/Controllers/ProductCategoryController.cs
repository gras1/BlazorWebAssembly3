using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorWebAssembly3.ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlazorWebAssembly3.Api.Controllers
{
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly ILogger<ProductCategoryController> _logger;
        private readonly DataAccess.IProductCategoryData _productCategoryData;

        public ProductCategoryController(ILogger<ProductCategoryController> logger, DataAccess.IProductCategoryData productCategoryData)
        {
            _logger = logger;
            _productCategoryData = productCategoryData;
        }

        [Route("/ProductCategory/GetAllAsync")]
        [HttpGet]
        public async Task<IEnumerable<ProductCategory>> GetAllAsync()
        {
            return await _productCategoryData.GetAllAsync();
        }

        [Route("/ProductCategory/SearchProductsAsync")]
        [HttpGet]
        public async Task<IEnumerable<ProductCategory>> SearchProductsAsync(string searchTerm)
        {
            return await _productCategoryData.SearchProductsAsync(searchTerm);
        }
    }
}
