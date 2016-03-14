namespace Ecommerce.DBComunicate
{
    using System.Collections.Generic;

    public class DBGroup
    {
        private IDictionary<string, DBFunction> _functions { get; }

        public DBGroup()
        {
            _functions = new Dictionary<string, DBFunction>();
        }

        public void AddFunction(DBFunction func)
        {
            _functions.Add(func.Name, func);
        }
    }
}