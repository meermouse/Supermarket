using Supermarket.Dto.Interface;
using System.Collections.Generic;

namespace Supermarket.Data.Interface
{
    public interface IDataAccess
    {
        /// <summary>
        /// Get available items
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetItems();

        /// <summary>
        /// Get available offers
        /// </summary>
        /// <returns></returns>
        IEnumerable<IOffer> GetOffers();

        /// <summary>
        /// Get available items with prices
        /// </summary>
        /// <returns></returns>
        IEnumerable<IItemPrice> GetItemPrices();
    }
}
