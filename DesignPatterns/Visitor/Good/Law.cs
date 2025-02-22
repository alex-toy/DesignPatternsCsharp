namespace Visitor.Good;

public class Law : Client
{
    public Law(string name, string email) : base(name, email)
    {
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitLaw(this);
    }
}
