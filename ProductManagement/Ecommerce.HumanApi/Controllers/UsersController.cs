namespace Ecommerce.HumanApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using Models;
    using Services;

    public class UsersController : ApiController
    {
        private IUserService _userService;

        public UsersController()
        {
            _userService = new UserService();
        }

        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return _userService.GetAll();
        }

        [HttpGet]
        public UserModel Get(int id)
        {
            return _userService.Get(id);
        }

        [HttpPost]
        public void Post(UserModel user)
        {
            _userService.Create(user);
        }

        [HttpPut]
        public void Update(UserModel user)
        {
            _userService.Update(user);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }
    }
}