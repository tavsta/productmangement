namespace Ecommerce.HumanApi.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Criterias;
    using DBComunicate;
    using Ecommerce.HumanApi.Models;

    public class UserService : IUserService
    {
        private static IList<UserModel> _user = new List<UserModel>();

        public void Create(UserModel user)
        {
            _user.Add(user);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel Get(int id)
        {
            return _user.Where(i => i.ID == id).FirstOrDefault();
        }

        public IEnumerable<UserModel> GetAll()
        {
            var dbObject = new DBObject();
            var criteria = new GetAllUsersCriteria();

            dbObject.Query<UserModel>(criteria);
            return _user;
        }

        public void Update(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}