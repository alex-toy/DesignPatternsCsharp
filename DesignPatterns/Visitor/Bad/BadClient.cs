namespace Visitor.Bad;

public abstract class BadClient
{
    protected string _name;
    protected string _email;

    public BadClient(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public abstract void SendEmail();
}
