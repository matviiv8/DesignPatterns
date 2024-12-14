namespace Visitor
{
    public class PerformanceEvaluator : IEmployeeVisitor
    {
        public void VisitPermanentEmployee(PermanentEmployee permanentEmployee)
        {
            Console.WriteLine($"Evaluating Performance of Permanent Employee: {permanentEmployee.Name}");
        }

        public void VisitContractEmployee(ContractEmployee contractEmployee)
        {
            Console.WriteLine($"Evaluating Performance of Contract Employee: {contractEmployee.Name}");
        }
    }
}
