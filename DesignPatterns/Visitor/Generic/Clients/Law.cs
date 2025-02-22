using Visitor.Generic.Visitors;

namespace Visitor.Generic.Clients;

public class Law : Client
{
    public Law(string name, string email) : base(name, email)
    {
    }

    public override void Accept(BaseVisitor visitor)
    {
        visitor.Visit(this);
    }
}
