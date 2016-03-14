using System;
using System.Collections.Generic;

namespace Ecommerce.DBComunicate
{
    public class Criteria : ICriteria
    {
        public IDictionary<string, object> GetParams()
        {
            throw new NotImplementedException();
        }

        public string GetSPName()
        {
            return string.Empty;
        }

        public virtual bool Validate()
        {
            return true;
        }
    }
}