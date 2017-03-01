using Supermarket.Dto.Interface;

namespace Supermarket.BusinessLogic.Interface
{
    public interface ISupermarketBusinessLogic
    {
        /// <summary>
        /// Calculates total cost of items in the checkout
        /// </summary>
        /// <param name="checkout"></param>
        /// <returns></returns>
        double ProcessCheckout(ICheckout checkout);
    }
}
