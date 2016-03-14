namespace Ecommerce.HumanApi.Models
{
    using System;
    using System.Collections.Generic;

    public class GroupModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatorID { get; set; }
        public int ModifierID { get; set; }
        public IList<UserModel> Members { get; set; }
    }
}