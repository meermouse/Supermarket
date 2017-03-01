using Supermarket.Dto.Interface;
using System.Collections.Generic;

namespace Supermarket.Dto.Implementation.Entity
{
    public class Checkout : ICheckout
    {
        public IEnumerable<string> Items { get; set; }
    }
}
