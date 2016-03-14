﻿using System;

namespace Ecommerce.Api.Model
{
    public class GroupModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatorID { get; set; }
        public int ModifierID { get; set; }
    }
}