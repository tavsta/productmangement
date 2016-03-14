namespace Ecommerce.HumanApi.Controllers
{
    using System.Web.Http;
    using Ecommerce.HumanApi.Models;

    [Route("api/[controller]")]
    public class LoginController : ApiController
    {
        // GET: api/values
        [HttpPost]
        public string Index(UserLoginDTO loginDTO)
        {
            return string.Empty;
        }
    }
}