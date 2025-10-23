using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooClassLibrary
{
    public class Money : IComparable<Money>
    {
        private decimal amount;
        private string currency;
        public decimal Amount { get { return amount; } }
        public string Currency { get { return currency; } }
        public Money(decimal amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public int CompareTo(Money? other)
        {
            return (int)(amount - other.Amount);
        }
    }
}
