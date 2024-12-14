using System.Globalization;

namespace Visitor
{
    public class PayrollCalculator : IEmployeeVisitor
    {
        public void VisitPermanentEmployee(PermanentEmployee permanentEmployee)
        {
            Console.WriteLine($"Permanent Employee '{permanentEmployee.Name}' Annual Salary: {permanentEmployee.AnnualSalary.ToString("C", new CultureInfo("en-US"))}");
        }

        public void VisitContractEmployee(ContractEmployee contractEmployee)
        {
            double totalPay = contractEmployee.HourlyRate * contractEmployee.HoursWorked;
            Console.WriteLine($"Contract Employee '{contractEmployee.Name}' Total Pay: {totalPay.ToString("C", new CultureInfo("en-US"))}");
        }
    }
}
