namespace Visitor
{
    public interface IEmployee
    {
        void Accept(IEmployeeVisitor visitor);
    }
}
