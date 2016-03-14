namespace Ecommerce.HumanApi.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNet.Mvc;
    using Models;
    using Services;

    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController()
        {
            //_userService = new UserService();
        }

        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return _userService.GetAll();
        }

        [HttpGet("{id}")]
        public UserModel Get(int id)
        {
            return _userService.Get(id);
        }

        [HttpPost]
        public void Create(UserModel user)
        {
            _userService.Create(user);
        }

        [HttpPost]
        public void Update(UserModel user)
        {
            _userService.Update(user);
        }

        [HttpGet]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }
    }
}