namespace ChainOfResponsability.Bad;

public class BadLogger
{
    public void Log(HttpRequest request)
    {
        Console.WriteLine($"{request.ValidatedUsername} - {request.ValidatedPassword} logged");
    }
}
