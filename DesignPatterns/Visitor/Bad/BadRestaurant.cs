namespace Visitor.Bad;

public class BadRestaurant : BadClient
{
    public BadRestaurant(string name, string email) : base(name, email)
    {
    }

    public override void SendEmail()
    {
        Console.WriteLine("Sending restaurant marketing tips email to " + _email);
    }
}
