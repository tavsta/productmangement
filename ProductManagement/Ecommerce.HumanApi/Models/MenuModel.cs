namespace Ecommerce.HumanApi.Models
{
    using System;
    using System.Collections.Generic;

    public class MenuModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public IEnumerable<MenuModel> SubMenus { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorID { get; set; }
    }
}