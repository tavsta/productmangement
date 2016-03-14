namespace Ecommerce.HumanApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using Models;
    using Services;

    public class MenuController : ApiController
    {
        private IMenuService _menuService { get; set; }

        public IEnumerable<MenuModel> Index()
        {
            return _menuService.GetMenu();
        }

        public IEnumerable<MenuModel> SubMenu(int id)
        {
            return _menuService.GetSubMenu(id);
        }

        public MenuModel MenuItem(int id)
        {
            return _menuService.Get(id);
        }
    }
}