using Supermarket.Data.Implementation;
using Supermarket.Data.Interface;
using System;

namespace Supermarket.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IDataAccess DataAccess = new DataAccess();
                SuperMarket SuperMarket = new SuperMarket(DataAccess);
                System.Console.WriteLine(SuperMarket.ProcessCheckout(string.Join(string.Empty,args)));
                System.Console.ReadKey();
            }
            catch(Exception ex)
            {
                ErrorHandling.ProcessException(ex);
            }
        }
    }
}
