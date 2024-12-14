using Visitor;

class Program
{
    static void Main(string[] args)
    {
        var employees = new List<IEmployee>
        {
            new PermanentEmployee { Name = "John Doe", AnnualSalary = 60000 },
            new ContractEmployee { Name = "Jane Smith", HourlyRate = 25, HoursWorked = 160 }
        };

        Console.WriteLine("Payroll Calculation:");
        var payrollCalculator = new PayrollCalculator();
        foreach (var employee in employees)
        {
            employee.Accept(payrollCalculator);
        }
        Console.WriteLine();

        Console.WriteLine("Performance Evaluation:");
        var performanceEvaluator = new PerformanceEvaluator();
        foreach (var employee in employees)
        {
            employee.Accept(performanceEvaluator);
        }
    }
}