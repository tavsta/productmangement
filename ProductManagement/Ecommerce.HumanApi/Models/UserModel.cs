using System;

namespace Ecommerce.HumanApi.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorID { get; set; }
    }
}