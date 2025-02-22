namespace Visitor.Bad;

public class BadRetail : BadClient
{
    public BadRetail(string name, string email) : base(name, email)
    {
    }

    public override void SendEmail()
    {
        Console.WriteLine("Sending retail marketing tips email to " + _email);
    }
}
