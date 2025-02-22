using Visitor.Generic.Visitors;

namespace Visitor.Generic.Structure;

public abstract class Acceptor
{
    public abstract void Accept(BaseVisitor visitor);
}
