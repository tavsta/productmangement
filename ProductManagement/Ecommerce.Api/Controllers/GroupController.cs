namespace Ecommerce.Api.Controllers
{
    using System.Collections.Generic;
    using Ecommerce.Api.Services;
    using Microsoft.AspNet.Mvc;
    using Model;

    public class GroupController : Controller
    {
        private IGroupService _groupService { get; set; }

        [HttpGet]
        public IEnumerable<GroupModel> Get()
        {
            return _groupService.GetAll();
        }

        [HttpGet("{id}")]
        public GroupModel Get(int id)
        {
            return _groupService.Get(id);
        }

        [HttpPost]
        public void Create(GroupModel user)
        {
            _groupService.Create(user);
        }

        [HttpPost]
        public void Update(GroupModel user)
        {
            _groupService.Update(user);
        }

        [HttpGet]
        public void Delete(int id)
        {
            _groupService.Delete(id);
        }

        [HttpGet]
        public IEnumerable<UserModel> GetMember(int id)
        {
            return _groupService.GetMembers(id);
        }

        [HttpGet]
        public void AddMember(int id, int userID)
        {
            _groupService.AddMember(id, userID);
        }

        [HttpGet]
        public void DeleteMember(int id, int userID)
        {
            _groupService.RemoveMember(id, userID);
        }

        [HttpGet]
        public IEnumerable<GroupModel> SubGroup(int id)
        {
            return _groupService.GetSubGroup(id);
        }
    }
}