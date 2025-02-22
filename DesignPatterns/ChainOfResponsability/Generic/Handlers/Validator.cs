using ChainOfResponsability.Generic.Structure;

namespace ChainOfResponsability.Generic.Handlers;

public class Validator : Handler<HttpRequest>
{
    public override bool DoHandle(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();

        request.ValidatedUsername = username.Trim();
        request.ValidatedPassword = password.Trim();

        Console.WriteLine($"{request.ValidatedUsername} - {request.ValidatedPassword} validated generic 1");

        return request.ValidatedUsername == "" || request.ValidatedPassword == "";
    }
}
