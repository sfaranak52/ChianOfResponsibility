using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoChainPattern
{
    public class ExpenseApprover
    {
        public void ApproveExpense(Expense expense)
        {
            if (expense.Amount <= 100)
            {
                Console.WriteLine($"Expense of ${expense.Amount} approved by Employee.");
            }
            else if (expense.Amount <= 500)
            {
                Console.WriteLine($"Expense of ${expense.Amount} approved by Manager.");
            }
            else if (expense.Amount <= 1000)
            {
                Console.WriteLine($"Expense of ${expense.Amount} approved by Director.");
            }
            else
            {
                Console.WriteLine($"Expense of ${expense.Amount} approved by CEO.");
            }
        }
    }
}
