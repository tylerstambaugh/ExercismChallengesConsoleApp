using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismChallengesConsoleApp
{
    public struct CurrencyAmount
    {
        private decimal amount;
        private string currency;

        public CurrencyAmount(decimal amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        // TODO: implement equality operators

        public static bool operator ==(CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            return true;
        }

        public static bool operator !=(CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            return true;
        }

        // TODO: implement comparison operators
        public static bool operator <(CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            return true;
        }

        public static bool operator >(CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            return true;
        }

        // TODO: implement arithmetic operators
        public static bool operator +(CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            return true;
        }

        public static bool operator -(CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            return true;
        }

        // TODO: implement type conversion operators
    }
    
}
