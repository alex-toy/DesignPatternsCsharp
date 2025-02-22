namespace ChainOfResponsability.Good;

public class Logger : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        Console.WriteLine($"{request.ValidatedUsername} - {request.ValidatedPassword} logged");
        return false;
    }
}
