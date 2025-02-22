namespace Visitor.Good;

public class Retail : Client
{
    public Retail(string name, string email) : base(name, email)
    {
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitRetail(this);
    }
}
