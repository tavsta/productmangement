namespace Ecommerce.DBComunicate
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;
    using System.Xml;

    public class DBObject
    {
        private static IDictionary<string, DBFunction> _funcs;

        public DBObject()
        {
            if (_funcs == null)
            {
                _funcs = new Dictionary<string, DBFunction>();
                var spFilePath = ConfigurationManager.AppSettings["SPFilePath"];
                ParseSPFile(spFilePath);
            }
        }

        private void ParseSPFile(string spFilePath)
        {
            var fullSPFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, spFilePath);
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fullSPFilePath);

            foreach (XmlNode groupNode in xDoc.DocumentElement.ChildNodes)
            {
                var groupName = groupNode.Attributes["Name"].Value;
                var dbName = groupNode.Attributes["DBName"].Value;

                var dbConnectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
                var group = new DBGroup() { Name = groupName, Connection = new SqlConnection(dbConnectionString) };
                foreach (XmlNode funcNode in groupNode.ChildNodes)
                {
                    var functionName = funcNode.Attributes["Name"].Value;
                    var functionDBName = funcNode.Attributes["DBName"] != null ? funcNode.Attributes["DBName"].Value : null;
                    _funcs.Add(functionName, new DBFunction() { Name = functionName, Group = group, DBName = functionDBName });
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
            var objectList = new List<T>();

            using (SqlCommand cmd = new SqlCommand(criteria.GetSPName(), connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                MapValueToDBValue(cmd.Parameters, criteria);

                connection.Open();

                var data = cmd.ExecuteReader();

                while (data.Read())
                {
                    var newObject = Activator.CreateInstance<T>();
                    var type = newObject.GetType();
                    foreach (var property in type.GetProperties())
                    {
                        if (data[property.Name] != DBNull.Value)
                        {
                            property.SetValue(newObject, data[property.Name]);
                        }
                    }

                    objectList.Add(newObject);
                }

                connection.Close();
            }
            return objectList;
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