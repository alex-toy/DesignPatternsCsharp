namespace Visitor.Generic.Structure;

public interface BaseVisitor<T>
{
    void Visit(T retail);
}
