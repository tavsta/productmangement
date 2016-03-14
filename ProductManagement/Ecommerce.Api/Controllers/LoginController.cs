namespace Ecommerce.Api.Controllers
{
    using Ecommerce.Api.Model;
    using Microsoft.AspNet.Mvc;

    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        // GET: api/values
        [HttpPost]
        public string Index(LoginDTO loginDTO)
        {
            return string.Empty;
        }
    }
}