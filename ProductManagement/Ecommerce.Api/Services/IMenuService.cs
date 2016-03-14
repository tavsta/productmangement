namespace Ecommerce.Api.Services
{
    using System.Collections.Generic;
    using Ecommerce.Api.Model;

    public interface IMenuService
    {
        IEnumerable<MenuModel> GetMenu();
        MenuModel Get(int id);
        IEnumerable<MenuModel> GetSubMenu(int id);
    }
}