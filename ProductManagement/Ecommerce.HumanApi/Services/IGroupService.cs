namespace Ecommerce.HumanApi.Services
{
    using System.Collections.Generic;
    using Ecommerce.HumanApi.Models;

    public interface IGroupService
    {
        GroupModel Get(int id);

        IEnumerable<GroupModel> GetAll();

        void Update(GroupModel user);

        void Create(GroupModel user);

        void Delete(int id);

        IEnumerable<UserModel> GetMembers(int id);

        void AddMember(int groupID, int userID);

        void RemoveMember(int groupID, int userID);

        IEnumerable<GroupModel> GetSubGroup(int id);
    }
}