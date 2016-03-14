namespace Ecommerce.ProductApi.Models
{
    using System;

    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorID { get; set; }
    }
}