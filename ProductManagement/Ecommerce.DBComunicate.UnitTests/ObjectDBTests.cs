namespace Ecommerce.DBComunicate.UnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class ObjectDBTests
    {
        private DBObject _dbObject;

        [SetUp]
        public void SetUp()
        {
            _dbObject = new DBObject("D://SPName.xml");
        }

        [Test]
        public void ObjectDB()
        {
        }
    }
}