namespace Ecommerce.HumanApi.Controllers
{
    using Ecommerce.HumanApi.Models;
    using Microsoft.AspNet.Mvc;

    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        // GET: api/values
        [HttpPost]
        public string Index(UserLoginDTO loginDTO)
        {
            return string.Empty;
        }
    }
}