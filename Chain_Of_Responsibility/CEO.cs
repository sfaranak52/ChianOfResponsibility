using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class CEO : IExpenseApprover
    {
        public void SetNextApprover(IExpenseApprover nextApprover)
        {
            // CEO is the final approver, so no next approver is set.
        }

        public void ApproveExpense(Expense expense)
        {
            Console.WriteLine($"Expense of ${expense.Amount} approved by CEO.");
        }
    }
}
