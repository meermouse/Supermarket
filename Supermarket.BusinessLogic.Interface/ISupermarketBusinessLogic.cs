using Supermarket.Dto.Implementation.Entity;

namespace Supermarket.BusinessLogic.Interface
{
    public interface ISupermarketBusinessLogic
    {
        /// <summary>
        /// Calculates total cost of items in the checkout
        /// </summary>
        /// <param name="checkout"></param>
        /// <returns></returns>
        double ProcessCheckout(Checkout checkout);
    }
}
