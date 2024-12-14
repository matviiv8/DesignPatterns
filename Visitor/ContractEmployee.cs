namespace Visitor
{
    public class ContractEmployee : IEmployee
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public void Accept(IEmployeeVisitor visitor)
        {
            visitor.VisitContractEmployee(this);
        }
    }
}
