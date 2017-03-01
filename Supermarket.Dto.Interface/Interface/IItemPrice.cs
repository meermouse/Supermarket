namespace Supermarket.Dto.Interface
{
    public interface IItemPrice
    {
        /// <summary>
        /// Item included in Offer
        /// </summary>
        string Item { get; set; }

        /// <summary>
        /// Price of Item
        /// </summary>
        double Price { get; set; }
    }
}