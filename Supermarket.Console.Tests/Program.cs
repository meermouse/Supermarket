using Supermarket.BusinessLogic.Implementation;
using Supermarket.BusinessLogic.Interface;
using Supermarket.Controllers;
using Supermarket.Data.Implementation;
using Supermarket.Data.Interface;
using System;

namespace Supermarket.Console.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataAccess dataAccess = new DataAccess();
            ISupermarketBusinessLogic supermarketBusinessLogic = new SupermarketBusinessLogic(dataAccess);
            SuperMarketController superMarket = new SuperMarketController(supermarketBusinessLogic, dataAccess);
            System.Console.WriteLine(Test(superMarket, "", 0));
            System.Console.WriteLine(Test(superMarket, "A", 50));
            System.Console.WriteLine(Test(superMarket, "AB", 80));
            System.Console.WriteLine(Test(superMarket, "CDBA", 115));
            System.Console.WriteLine(Test(superMarket, "AA", 100));
            System.Console.WriteLine(Test(superMarket, "AAA", 130));
            System.Console.WriteLine(Test(superMarket, "AAABB", 175));
            System.Console.ReadKey();
        }

        private static string Test(SuperMarketController superMarket, string input, double expectedOutput)
        {
            try
            {
                double output = superMarket.ProcessCheckout(input);
                return String.Format("Input: {0} Expected Ouput: {1} Actual Output: {2} {3}", input, expectedOutput.ToString(), output.ToString(), output == expectedOutput ? "PASS" : "FAIL");
            }
            catch (Exception ex)
            {
                ErrorHandling.ProcessException(ex);
                return String.Format("Input: {0} Expected Ouput: {1} EXCEPTION FAIL", input, expectedOutput.ToString());
            }
        }

    }
}