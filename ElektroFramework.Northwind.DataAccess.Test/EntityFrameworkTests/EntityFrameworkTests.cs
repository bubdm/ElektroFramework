using ElektroFramework.Northwind.DataAccess.Concrete.EntityFramework;
using NUnit.Framework;

namespace ElektroFramework.Northwind.DataAccess.Test.EntityFrameworkTests
{
    [TestFixture]
    public class EntityFrameworkTests
    {
        [Test]
        public void get_all_returns_all_products()
        {
            EfProductDal productDal=new EfProductDal();
            var result = productDal.GetList();
            Assert.AreEqual(85,result.Count);
        }
    }
}