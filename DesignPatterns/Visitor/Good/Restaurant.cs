namespace Visitor.Good;

public class Restaurant :  Client
{
    public Restaurant(string name, string email) : base(name, email)
    {
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitRestaurant(this);
    }
}
