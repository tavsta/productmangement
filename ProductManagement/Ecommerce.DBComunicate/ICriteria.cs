using System.Collections.Generic;

namespace Ecommerce.DBComunicate
{
    public interface ICriteria
    {
        string SPName { get; set; }

        IDictionary<string, object> GetParams();

        bool Validate();
    }
}