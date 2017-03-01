using Supermarket.Data.Interface;
using Supermarket.Dto.Implementation.Entity;
using Supermarket.Dto.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Supermarket.Console
{
    public class ProcessConsole
    {
        private readonly IEnumerable<string> AvailableItems;
        private readonly IDataAccess IDataAccess;

        public ProcessConsole(IDataAccess IDataAccess)
        {
            this.IDataAccess = IDataAccess;
            this.AvailableItems = this.IDataAccess.GetItems();
        }

        public ICheckout ProcessCheckout(string s)
        {
            if (!this.ValidateStringInput(s))
            {
                throw new Exception("Invalid Input");
            }

            return new Checkout()
            { 
                Items = s.Select(c => c.ToString()).ToList()
            };
        }

        private bool ValidateStringInput(string input)
        {
            if (input == null) return false;

            if (!string.IsNullOrWhiteSpace(input) && !Regex.IsMatch(String.Join(string.Empty, input), @"^[a-zA-Z]+$")) return false;

            IEnumerable<string> items = this.IDataAccess.GetItems();
            
            foreach(char c in input)
            {
                if (!items.Contains<string>(c.ToString())) return false;
            }

            return true;
        }
    }
}
