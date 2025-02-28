using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    public class Employee : IExpenseApprover
    {
        private IExpenseApprover _nextApprover;

        public void SetNextApprover(IExpenseApprover nextApprover)
        {
            _nextApprover = nextApprover;
        }

        public void ApproveExpense(Expense expense)
        {
            if (expense.Amount <= 100)
            {
                Console.WriteLine($"Expense of ${expense.Amount} approved by Employee.");
            }
            else if (_nextApprover != null)
            {
                _nextApprover.ApproveExpense(expense);
            }
            else
            {
                Console.WriteLine($"Expense of ${expense.Amount} cannot be approved.");
            }
        }
    }
}
