namespace Ecommerce.ProductApi.Services
{
    using System;
    using System.Collections.Generic;
    using Ecommerce.ProductApi.Models;

    public class CategoryService : ICategoryService
    {
        public void AddProduct(int categoryID, int productID)
        {
            throw new NotImplementedException();
        }

        public void Create(CategoryModel category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryModel> Get()
        {
            throw new NotImplementedException();
        }

        public CategoryModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetProducts(int categoryID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryModel> GetSubCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(int categoryID, int productID)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryModel category)
        {
            throw new NotImplementedException();
        }
    }
}