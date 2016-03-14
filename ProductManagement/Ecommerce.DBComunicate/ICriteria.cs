using System.Collections.Generic;

namespace Ecommerce.DBComunicate
{
    public interface ICriteria
    {
        string GetSPName();

        IDictionary<string, object> GetParams();

        bool Validate();
    }
}