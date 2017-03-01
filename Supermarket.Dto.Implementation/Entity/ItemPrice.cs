using Supermarket.Dto.Interface;

namespace Supermarket.Dto.Implementation.Entity
{
    public class ItemPrice : IItemPrice
    {
        public string Item { get; set; }

        public double Price { get; set; }
    }
}
