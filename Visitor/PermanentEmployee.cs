namespace Visitor
{
    public class PermanentEmployee : IEmployee
    {
        public string Name { get; set; }
        public double AnnualSalary { get; set; }

        public void Accept(IEmployeeVisitor visitor)
        {
            visitor.VisitPermanentEmployee(this);
        }
    }
}
