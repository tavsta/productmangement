namespace Ecommerce.HumanApi.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Ecommerce.HumanApi.Models;

    public class GroupService : IGroupService
    {
        private static IList<GroupModel> _groups;

        public GroupService()
        {
            _groups = new List<GroupModel>();
        }

        public void AddMember(int groupID, int userID)
        {
            //todo
        }

        public void Create(GroupModel group)
        {
            _groups.Add(group);
        }

        public void Delete(int id)
        {
            var group = _groups.Where(i => i.ID == id).FirstOrDefault();

            _groups.Remove(group);
        }

        public GroupModel Get(int id)
        {
            return _groups.Where(i => i.ID == id).FirstOrDefault();
        }

        public IEnumerable<GroupModel> GetAll()
        {
            return _groups;
        }

        public IEnumerable<UserModel> GetMembers(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GroupModel> GetSubGroup(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveMember(int groupID, int userID)
        {
            throw new NotImplementedException();
        }

        public void Update(GroupModel user)
        {
            throw new NotImplementedException();
        }
    }
}