using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Controllers.Interface
{
    public interface ISuperMarketController
    {
        /// <summary>
        /// Process input to produce checkout amount
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        double ProcessCheckout(string input);
    }
}
