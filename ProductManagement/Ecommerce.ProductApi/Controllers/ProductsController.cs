namespace Ecommerce.ProductApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using Models;
    using Services;

    public class ProductsController : ApiController
    {
        private IProductService _productService;
        public ProductsController()
        {
            _productService = new ProductService();
        }
        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            return _productService.Get();
        }

        [HttpGet]
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