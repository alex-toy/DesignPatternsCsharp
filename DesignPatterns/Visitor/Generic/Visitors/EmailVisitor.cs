using Visitor.Generic.Clients;

namespace Visitor.Generic.Visitors;

public class EmailVisitor : BaseVisitor
{
    public void Visit(Law law)
    {
        Console.WriteLine("Sending law marketing tips email to " + law.GetEmail());
    }

    public void Visit(Restaurant restaurant)
    {
        Console.WriteLine("Sending restaurant marketing tips email to " + restaurant.GetEmail());
    }

    public void Visit(Retail retail)
    {
        Console.WriteLine("Sending retail marketing tips email to " + retail.GetEmail());
    }
}
