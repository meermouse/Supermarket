namespace Supermarket.Dto.Interface
{
    public interface IOffer
    {
        /// <summary>
        /// Number of SKUs required for offer
        /// </summary>
        int Number { get; set; }

        /// <summary>
        /// Item included in Offer
        /// </summary>
        string Item { get; set; }

        /// <summary>
        /// New Price when Number is met
        /// </summary>
        double Price { get; set; }
    }
}