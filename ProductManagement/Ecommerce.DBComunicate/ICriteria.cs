using System.Collections.Generic;

namespace Ecommerce.DBComunicate
{
    public interface ICriteria
    {
        string GetSPName();

        bool Validate();
    }
}