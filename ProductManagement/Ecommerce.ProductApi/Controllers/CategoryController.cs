namespace Ecommerce.ProductApi.Controllers
{
    using System.Collections.Generic;
    using Ecommerce.ProductApi.Services;
    using Microsoft.AspNet.Mvc;
    using Models;

    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public IEnumerable<CategoryModel> Get()
        {
            return _categoryService.Get();
        }

        public CategoryModel Get(int id)
        {
            return _categoryService.Get(id);
        }

        [HttpPost]
        public void Create(CategoryModel category)
        {
            _categoryService.Create(category);
        }

        [HttpPost]
        public void Update(CategoryModel category)
        {
            _categoryService.Update(category);
        }

        public void Delete(int id)
        {
            _categoryService.Delete(id);
        }

        public IEnumerable<CategoryModel> SubCategory(int id)
        {
            return _categoryService.GetSubCategory(id);
        }

        public IEnumerable<ProductModel> GetProducts(int categoryID)
        {
            return _categoryService.GetProducts(categoryID);
        }

        public void AddProduct(int categoryID, int productID)
        {
            _categoryService.AddProduct(categoryID, productID);
        }

        public void RemoveProduct(int categoryID, int productID)
        {
            _categoryService.RemoveProduct(categoryID, productID);
        }
    }
}