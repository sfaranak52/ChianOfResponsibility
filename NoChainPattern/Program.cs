using NoChainPattern;

class Program
{
    static void Main(string[] args)
    {
        // Create the ExpenseApprover
        ExpenseApprover approver = new ExpenseApprover();

        // Create expenses
        Expense expense1 = new Expense(50);
        Expense expense2 = new Expense(300);
        Expense expense3 = new Expense(800);
        Expense expense4 = new Expense(1500);

        // Process expenses
        approver.ApproveExpense(expense1); // Approved by Employee
        approver.ApproveExpense(expense2); // Approved by Manager
        approver.ApproveExpense(expense3); // Approved by Director
        approver.ApproveExpense(expense4); // Approved by CEO
    }
}