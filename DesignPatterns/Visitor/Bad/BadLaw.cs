namespace Visitor.Bad;

public class BadLaw : BadClient
{
    public BadLaw(string name, string email) : base(name, email)
    {
    }

    public override void SendEmail()
    {
        Console.WriteLine("Sending law marketing tips email to " + _email);
    }
}
