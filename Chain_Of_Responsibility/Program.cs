using Chain_Of_Responsibility;

class Program
{
    static void Main(string[] args)
    {
        // Create the chain of responsibility
        IExpenseApprover employee = new Employee();
        IExpenseApprover manager = new Manager();
        IExpenseApprover director = new Director();
        IExpenseApprover ceo = new CEO();

        employee.SetNextApprover(manager);
        manager.SetNextApprover(director);
        director.SetNextApprover(ceo);

        // Create expenses
        Expense expense1 = new Expense(50);
        Expense expense2 = new Expense(300);
        Expense expense3 = new Expense(800);
        Expense expense4 = new Expense(1500);

        // Process expenses
        employee.ApproveExpense(expense1); // Approved by Employee
        employee.ApproveExpense(expense2); // Approved by Manager
        employee.ApproveExpense(expense3); // Approved by Director
        employee.ApproveExpense(expense4); // Approved by CEO
    }
}