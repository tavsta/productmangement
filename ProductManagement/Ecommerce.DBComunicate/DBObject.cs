namespace Ecommerce.DBComunicate
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Xml;
    using System.Xml.Linq;

 

    public class DBObject
    {
        private IEnumerable<SqlConnection> _connectionList;

        public DBObject(string spFilePath)
        {
            if (string.IsNullOrEmpty(spFilePath))
            {
                spFilePath = ConfigurationManager.AppSettings["SPFilePath"];
            }

            var xml = XDocument.Load(spFilePath);
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(spFilePath);
            foreach(var groupNode in xDoc.DocumentElement.ChildNodes)
            {
            }
        }

        public IEnumerable<T> Query<T>(ICriteria criteria)
        {
            return new List<T>();
        }
    }
}