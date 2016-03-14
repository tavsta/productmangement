using System.Collections.Generic;
using Ecommerce.ProductApi.Models;

namespace Ecommerce.ProductApi.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryModel> Get();

        CategoryModel Get(int id);

        void Update(CategoryModel category);

        void Create(CategoryModel category);

        void Delete(int id);

        IEnumerable<CategoryModel> GetSubCategory(int id);

        void AddProduct(int categoryID, int productID);

        void RemoveProduct(int categoryID, int productID);
        IEnumerable<ProductModel> GetProducts(int categoryID);
    }
}