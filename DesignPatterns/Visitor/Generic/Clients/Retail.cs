using Visitor.Generic.Visitors;

namespace Visitor.Generic.Clients;

public class Retail : Client
{
    public Retail(string name, string email) : base(name, email)
    {
    }

    public override void Accept(BaseVisitor visitor)
    {
        visitor.Visit(this);
    }
}
