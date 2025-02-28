using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class Expense
    {
        public decimal Amount { get; set; }

        public Expense(decimal amount)
        {
            Amount = amount;
        }
    }
}
