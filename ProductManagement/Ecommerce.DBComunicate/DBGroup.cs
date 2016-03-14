namespace Ecommerce.DBComunicate
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    public class DBGroup
    {
        private IDictionary<string, DBFunction> _functions { get; }

        public string Name { get; set; }

        public SqlConnection Connection { get; set; }

        public DBGroup()
        {
            _functions = new Dictionary<string, DBFunction>();
        }
    }
}