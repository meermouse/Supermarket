using NUnit.Framework;
using Supermarket.BusinessLogic.Implementation;
using Supermarket.BusinessLogic.Interface;
using Supermarket.Console;
using Supermarket.Controllers;
using Supermarket.Data.Implementation;
using Supermarket.Data.Interface;

namespace NUnitTestProject1
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            IDataAccess dataAccess = new DataAccess();
            ISupermarketBusinessLogic supermarketBusinessLogic = new SupermarketBusinessLogic(dataAccess);
            SuperMarketController superMarket = new SuperMarketController(supermarketBusinessLogic, dataAccess);
            string input = "";
            double expectedResult = superMarket.ProcessCheckout(input);
            Assert.That(expectedResult, Is.EqualTo(0));
        }
    }
}