using ChainOfResponsability.Generic.Structure;

namespace ChainOfResponsability.Generic.Handlers;

public class AuthenticatorB : Handler<HttpRequest>
{
    public override bool DoHandle(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();
        Console.WriteLine($"{username} - {password} authenticated generic B");
        return !(username == "danny" && password == "123");
    }
}
 