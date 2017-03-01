using Supermarket.Data.Interface;
using Supermarket.Dto.Implementation.Entity;
using Supermarket.Dto.Implementation.Enum;
using Supermarket.Dto.Interface;
using System.Collections.Generic;

namespace Supermarket.Data.Implementation
{
    public class DataAccess : IDataAccess
    {
        public IEnumerable<string> GetItems()
        {
            return new List<string>()
            {
                ItemEnum.A, ItemEnum.B, ItemEnum.C, ItemEnum.D
            };
        }

        public IEnumerable<IItemPrice> GetItemPrices()
        {
            return new List<ItemPrice>()
            {
                new ItemPrice { Item = ItemEnum.A, Price = 50 },
                new ItemPrice { Item = ItemEnum.B, Price = 30 },
                new ItemPrice { Item = ItemEnum.C, Price = 20 },
                new ItemPrice { Item = ItemEnum.D, Price = 15 }
            };
        }

        public IEnumerable<IOffer> GetOffers()
        {
            return new List<Offer>()
            {
                new Offer { Item = ItemEnum.A, Number = 3, Price = 130 },
                new Offer { Item = ItemEnum.B, Number = 2, Price = 45 }
            };
        }
    }
}
