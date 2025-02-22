using ChainOfResponsability.Generic.Structure;

namespace ChainOfResponsability.Generic.Handlers;

public class Logger : Handler<HttpRequest>
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine($"{request.ValidatedUsername} - {request.ValidatedPassword} logged  generic 1");
        return false;
    }
}
 