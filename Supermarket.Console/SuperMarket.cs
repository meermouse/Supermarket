using Supermarket.BusinessLogic.Implementation;
using Supermarket.BusinessLogic.Interface;
using Supermarket.Data.Interface;
using Supermarket.Dto.Interface;

namespace Supermarket.Console
{
    public class SuperMarket
    {
        private readonly IDataAccess DataAccess;
        public SuperMarket(IDataAccess DataAccess)
        {
            this.DataAccess = DataAccess;
        }

        public double ProcessCheckout(string input)
        {
            ProcessConsole processConsole = new ProcessConsole(DataAccess);
            ICheckout checkout = processConsole.ProcessCheckout(string.Join(string.Empty,input));
            ISupermarketBusinessLogic SKUBusinessLogic = new SupermarketBusinessLogic(DataAccess);

            return SKUBusinessLogic.ProcessCheckout(checkout);
        }
    }
}
