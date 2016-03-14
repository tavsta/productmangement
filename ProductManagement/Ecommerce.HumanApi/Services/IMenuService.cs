namespace Ecommerce.HumanApi.Services
{
    using System.Collections.Generic;
    using Ecommerce.HumanApi.Models;

    public interface IMenuService
    {
        IEnumerable<MenuModel> GetMenu();
        MenuModel Get(int id);
        IEnumerable<MenuModel> GetSubMenu(int id);
    }
}