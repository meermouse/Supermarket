using Supermarket.Data.Interface;
using SuperMarket.Controllers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Supermarket.Dto.Implementation.Entity;
using Supermarket.BusinessLogic.Interface;

namespace Supermarket.Controllers
{
    public class SuperMarketController : ISuperMarketController
    {
        private IDataAccess _dataAccess;
        private ISupermarketBusinessLogic _supermarketBusinessLogic;

        public SuperMarketController(ISupermarketBusinessLogic supermarketBusinessLogic, IDataAccess dataAccess)
        {
            this._supermarketBusinessLogic = supermarketBusinessLogic;
            this._dataAccess = dataAccess;
        }

        public double ProcessCheckout(string input)
        {
            if (!this.ValidateStringInput(input))
            {
                throw new Exception("Invalid Input");
            }

            Checkout checkout = new Checkout()
            {
                Items = input.Select(c => c.ToString()).ToList()
            };

            return this._supermarketBusinessLogic.ProcessCheckout(checkout);
        }

        private bool ValidateStringInput(string input)
        {
            if (input == null) return false;

            if (!string.IsNullOrWhiteSpace(input) && !Regex.IsMatch(String.Join(string.Empty, input), @"^[a-zA-Z]+$")) return false;

            IEnumerable<string> items = this._dataAccess.GetItems();

            foreach (char c in input)
            {
                if (!items.Contains<string>(c.ToString())) return false;
            }

            return true;
        }
    }
}
