namespace Ecommerce.HumanApi.Controllers
{
    using System.Collections.Generic;
    using Ecommerce.HumanApi.Services;
    using Microsoft.AspNet.Mvc;
    using Models;

    public class GroupsController : Controller
    {
        private IGroupService _groupService { get; set; }


        public GroupsController()
        {
            _groupService = new GroupService();
        }
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
        public void Post(GroupModel user)
        {
            _groupService.Create(user);
        }

        [HttpPut]
        public void Put(GroupModel user)
        {
            _groupService.Update(user);
        }

        [HttpDelete]
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