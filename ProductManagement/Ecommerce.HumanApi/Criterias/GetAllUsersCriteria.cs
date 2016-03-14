namespace Ecommerce.HumanApi.Criterias
{
    using Ecommerce.DBComunicate;

    public class GetAllUsersCriteria : Criteria, ICriteria
    {
        public string GetSPName()
        {
            return "User_GetAllUsers";
        }
    }
}