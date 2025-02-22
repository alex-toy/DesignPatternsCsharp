using Visitor.Generic.Visitors;

namespace Visitor.Generic.Clients;

public class Restaurant : Client
{
    public Restaurant(string name, string email) : base(name, email)
    {
    }

    public override void Accept(BaseVisitor visitor)
    {
        visitor.Visit(this);
    }
}
