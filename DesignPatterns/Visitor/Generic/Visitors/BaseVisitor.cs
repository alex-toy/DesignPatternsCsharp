using Visitor.Generic.Clients;
using Visitor.Generic.Structure;

namespace Visitor.Generic.Visitors;

public interface BaseVisitor : BaseVisitor<Retail>, BaseVisitor<Law>, BaseVisitor<Restaurant>
{
}
