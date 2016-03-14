namespace Ecommerce.Api.Services
{
    using System.Collections.Generic;
    using Ecommerce.Api.Model;

    public interface IUserService
    {
        UserModel Get(int id);

        IEnumerable<UserModel> GetAll();

        void Update(UserModel user);

        void Create(UserModel user);

        void Delete(int id);
    }
}