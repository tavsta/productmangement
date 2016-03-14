namespace Ecommerce.ProductApi.Services
{
    using System.Collections.Generic;
    using Ecommerce.ProductApi.Models;

    public interface IProductService
    {
        IEnumerable<ProductModel> Get();
        ProductModel Get(int id);
        void Update(ProductModel product);
        void Delete(int id);
        void Create(ProductModel product);
    }
}