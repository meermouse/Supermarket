using NUnit.Framework;
using Supermarket.BusinessLogic.Implementation;
using Supermarket.BusinessLogic.Interface;
using Supermarket.Controllers;
using Supermarket.Data.Implementation;
using Supermarket.Data.Interface;
using SuperMarket.Controllers.Interface;

namespace Supermarket.Console.Tests
{
    [TestFixture]
    public class SupermarketTests
    {
        [Test]
        public void BlankCheck()
        {
            IDataAccess dataAccess = new DataAccess();
            ISupermarketBusinessLogic supermarketBusinessLogic = new SupermarketBusinessLogic(dataAccess);
            ISuperMarketController superMarket = new SuperMarketController(supermarketBusinessLogic, dataAccess);
            string input = "";
            double expectedResult = superMarket.ProcessCheckout(input);
            Assert.That(expectedResult, Is.EqualTo(0));
        }

        [Test]
        public void A_50()
        {
            IDataAccess dataAccess = new DataAccess();
            ISupermarketBusinessLogic supermarketBusinessLogic = new SupermarketBusinessLogic(dataAccess);
            ISuperMarketController superMarket = new SuperMarketController(supermarketBusinessLogic, dataAccess);
            string input = "A";
            double expectedResult = superMarket.ProcessCheckout(input);
            Assert.That(expectedResult, Is.EqualTo(50));
        }

        [Test]
        public void AB_80()
        {
            IDataAccess dataAccess = new DataAccess();
            ISupermarketBusinessLogic supermarketBusinessLogic = new SupermarketBusinessLogic(dataAccess);
            ISuperMarketController superMarket = new SuperMarketController(supermarketBusinessLogic, dataAccess);
            string input = "AB";
            double expectedResult = superMarket.ProcessCheckout(input);
            Assert.That(expectedResult, Is.EqualTo(80));
        }

        [Test]
        public void CDBA_115()
        {
            IDataAccess dataAccess = new DataAccess();
            ISupermarketBusinessLogic supermarketBusinessLogic = new SupermarketBusinessLogic(dataAccess);
            ISuperMarketController superMarket = new SuperMarketController(supermarketBusinessLogic, dataAccess);
            string input = "CDBA";
            double expectedResult = superMarket.ProcessCheckout(input);
            Assert.That(expectedResult, Is.EqualTo(115));
        }

        [Test]
        public void AA_100()
        {
            IDataAccess dataAccess = new DataAccess();
            ISupermarketBusinessLogic supermarketBusinessLogic = new SupermarketBusinessLogic(dataAccess);
            SuperMarketController superMarket = new SuperMarketController(supermarketBusinessLogic, dataAccess);
            string input = "AA";
            double expectedResult = superMarket.ProcessCheckout(input);
            Assert.That(expectedResult, Is.EqualTo(100));
        }

        [Test]
        public void AAA_130()
        {
            IDataAccess dataAccess = new DataAccess();
            ISupermarketBusinessLogic supermarketBusinessLogic = new SupermarketBusinessLogic(dataAccess);
            ISuperMarketController superMarket = new SuperMarketController(supermarketBusinessLogic, dataAccess);
            string input = "AAA";
            double expectedResult = superMarket.ProcessCheckout(input);
            Assert.That(expectedResult, Is.EqualTo(130));
        }

        [Test]
        public void AAABB_175()
        {
            IDataAccess dataAccess = new DataAccess();
            ISupermarketBusinessLogic supermarketBusinessLogic = new SupermarketBusinessLogic(dataAccess);
            SuperMarketController superMarket = new SuperMarketController(supermarketBusinessLogic, dataAccess);
            string input = "AAABB";
            double expectedResult = superMarket.ProcessCheckout(input);
            Assert.That(expectedResult, Is.EqualTo(175));
        }
    }
}
