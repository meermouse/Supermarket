using System.Collections.Generic;

namespace Supermarket.Dto.Interface
{
    public interface ICheckout
    {
        /// <summary>
        /// List of Items purchased
        /// </summary>
        IEnumerable<string> Items { get; set; }
    }
}