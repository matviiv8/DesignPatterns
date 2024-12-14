namespace Visitor
{
    public interface IEmployeeVisitor
    {
        void VisitPermanentEmployee(PermanentEmployee permanentEmployee);
        void VisitContractEmployee(ContractEmployee contractEmployee);
    }
}
