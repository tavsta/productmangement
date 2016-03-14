namespace Ecommerce.HumanApi.Services
{
    using System.Collections.Generic;
    using Ecommerce.HumanApi.Models;

    public interface IGroupService
    {
        GroupModel Get(int id);

        IEnumerable<GroupModel> GetAll();

        void Update(GroupModel group);

        void Create(GroupModel group);

        void Delete(int id);

        IEnumerable<UserModel> GetMembers(int id);

        void AddMember(int groupID, int userID);

        void RemoveMember(int groupID, int userID);

        IEnumerable<GroupModel> GetSubGroup(int id);
    }
}