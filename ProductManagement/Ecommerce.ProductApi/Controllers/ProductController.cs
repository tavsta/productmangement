namespace Ecommerce.ProductApi.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNet.Mvc;
    using Models;
    using Services;

    public class ProductController : Controller
    {
        private IProductService _productService;

        public IEnumerable<ProductModel> Get()
        {
            return _productService.Get();
        }

        public ProductModel Get(int id)
        {
            return _productService.Get(id);
        }

        [HttpPost]
        public void Create(ProductModel product)
        {
            _productService.Create(product);
        }

        [HttpPost]
        public void Update(ProductModel product)
        {
            _productService.Update(product);
        }

        public void Delete(int id)
        {
            _productService.Delete(id);
        }
    }
}