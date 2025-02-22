using Visitor.Generic.Structure;

namespace Visitor.Generic;

public abstract class Client : Acceptor
{
    protected string _name;
    protected string _email;

    public Client(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }
}
