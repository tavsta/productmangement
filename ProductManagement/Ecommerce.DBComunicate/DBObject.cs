namespace Ecommerce.DBComunicate
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Xml;
    using System.Xml.Linq;

    public class DBObject
    {
        private IDictionary<string, DBFunction> _funcs = new Dictionary<string, DBFunction>();

        public DBObject()
        {
            var spFilePath = ConfigurationManager.AppSettings["SPFilePath"];
            ParseSPFile(spFilePath);
        }

        private void ParseSPFile(string spFilePath)
        {
            var xml = XDocument.Load(spFilePath);
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(spFilePath);

            foreach (XmlNode groupNode in xDoc.DocumentElement.ChildNodes)
            {
                var groupName = groupNode.Attributes["Name"].Value;
                var dbConnectionString = groupNode.Attributes["DBName"].Value;
                var group = new DBGroup() { Name = groupName, Connection = new SqlConnection(dbConnectionString) };

                foreach (XmlNode funcNode in groupNode.ChildNodes)
                {
                    var functionName = funcNode.Attributes["Name"].Value;
                    var functionDBName = string.IsNullOrEmpty(funcNode.Attributes["DBName"].Value) ? funcNode.Attributes["DBName"].Value : null;
                    _funcs.Add(functionName, new DBFunction() { Name = functionName, Group = group });
                }
            }
        }

        private SqlConnection GetConnectionOfFunc(string name)
        {
            return _funcs[name].Group.Connection;
        }

        public IEnumerable<T> Query<T>(ICriteria criteria)
        {
            var connection = GetConnectionOfFunc(criteria.GetSPName());
            var dataList = new List<T>();

            using (SqlCommand cmd = new SqlCommand(criteria.GetSPName(), connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                MapValueToDBValue(cmd.Parameters, criteria);

                connection.Open();

                var data = cmd.ExecuteReader();

                while (data.Read())
                {
                    //Todo
                }

                connection.Close();
            }
            return dataList;
        }

        private void MapValueToDBValue(SqlParameterCollection parameters, ICriteria criteria)
        {
            var properties = criteria.GetType().GetProperties();
            SqlDbType dbType;

            foreach (var property in properties)
            {
                var realType = property.GetType();

                if (realType == typeof(Int64))
                {
                    dbType = SqlDbType.BigInt;
                }
                else if (realType == typeof(int))
                {
                    dbType = SqlDbType.Int;
                }
                else if (realType == typeof(decimal))
                {
                    dbType = SqlDbType.Decimal;
                }
                else if (realType == typeof(bool))
                {
                    dbType = SqlDbType.Bit;
                }
                else if (realType == typeof(char))
                {
                    dbType = SqlDbType.VarChar;
                }
                else if (realType == typeof(DateTime))
                {
                    dbType = SqlDbType.DateTime;
                }
                else
                {
                    dbType = SqlDbType.VarChar;
                }

                parameters.Add(property.Name, dbType).Value = property.GetValue(criteria);
            }
        }
    }
}