using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
            if (currencyAmountA.currency == currencyAmountB.currency)
            {
                {
                    return (currencyAmountA.amount == currencyAmountB.amount);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static bool operator !=(CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            if (currencyAmountA.currency == currencyAmountB.currency)
            {
                {
                    return (currencyAmountA.amount != currencyAmountB.amount);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        // TODO: implement comparison operators
        public static bool operator <(CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            if (currencyAmountA.currency == currencyAmountB.currency)
            {
                {
                    return (currencyAmountA.amount < currencyAmountB.amount);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static bool operator >(CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            if (currencyAmountA.currency == currencyAmountB.currency)
            {
                {
                    return (currencyAmountA.amount > currencyAmountB.amount);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        // TODO: implement arithmetic operators
        public static decimal operator +(CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            if (currencyAmountA.currency == currencyAmountB.currency)
            {
                {
                    return (currencyAmountA.amount + currencyAmountB.amount);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static decimal operator - (CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            if (currencyAmountA.currency == currencyAmountB.currency)
            {
                {
                    return (currencyAmountA.amount - currencyAmountB.amount);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static decimal operator * (CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            if (currencyAmountA.currency == currencyAmountB.currency)
            {
                {
                    return (currencyAmountA.amount * currencyAmountB.amount);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static decimal operator / (CurrencyAmount currencyAmountA, CurrencyAmount currencyAmountB)
        {
            if (currencyAmountA.currency == currencyAmountB.currency)
            {
                {
                    return (currencyAmountA.amount / currencyAmountB.amount);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        // TODO: implement type conversion operators
        public static explicit operator double(CurrencyAmount currencyAmount)
        {
            return (double) currencyAmount.amount;
        }

        public static implicit operator decimal(CurrencyAmount currencyAmount)
        {
            return (decimal)currencyAmount.amount;
        }
    }
    
}
