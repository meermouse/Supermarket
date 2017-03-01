using Supermarket.BusinessLogic.Interface;
using Supermarket.Data.Interface;
using Supermarket.Dto.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket.BusinessLogic.Implementation
{
    public class SupermarketBusinessLogic : ISupermarketBusinessLogic
    {
        private readonly IDataAccess _dataAccess;

        private IEnumerable<IItemPrice> itemPrices;
        private IEnumerable<IOffer> offers;

        public SupermarketBusinessLogic(IDataAccess IDataAccess)
        {
            this._dataAccess = IDataAccess;
        }

        public double ProcessCheckout(ICheckout checkout)
        {
            double total = 0;
            this.itemPrices = this._dataAccess.GetItemPrices();
            this.offers = this._dataAccess.GetOffers();
            Dictionary<string, int> multiples = new Dictionary<string, int>();

            foreach (string item in checkout.Items)
            {
                if (multiples.ContainsKey(item))
                {
                    multiples[item]++;
                }
                else
                {
                    multiples.Add(item, 1);
                }
            }

            foreach (string item in multiples.Keys)
            {
                IOffer offer = this.offers.FirstOrDefault(o => o.Item == item);
                IItemPrice itemPrice = this.itemPrices.FirstOrDefault(ip => ip.Item == item);
                if (offer != null && itemPrice != null)
                {
                    int numberOfOffers = multiples[item] / offer.Number;
                    int remainer = multiples[item] % offer.Number;

                    total = total + (numberOfOffers * offer.Price) + (remainer * itemPrice.Price);
                }
                else if(itemPrice != null)
                {
                    total = total + (multiples[item] * itemPrice.Price);
                }
            }

            return total;
        }
    }
}
