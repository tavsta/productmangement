namespace Ecommerce.HumanApi.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNet.Mvc;
    using Models;
    using Services;

    public class MenuController : Controller
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