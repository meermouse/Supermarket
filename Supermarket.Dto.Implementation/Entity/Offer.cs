using Supermarket.Dto.Interface;

namespace Supermarket.Dto.Implementation.Entity
{
    public class Offer : IOffer
    {
        public string Item { get; set; }

        public int Number { get; set; }

        public double Price { get; set; }
    }
}
