namespace Ecommerce.ProductApi.Models
{
    using System;

    public class CategoryModel
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorID { get; set; }
        public int? BeLongTo { get; set; }
    }
}