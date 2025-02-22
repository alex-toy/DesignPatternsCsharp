namespace ChainOfResponsability.Bad;

public class BadAuthenticator
{
    public bool Authenticate(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();
        Console.WriteLine($"{username} - {password} authenticated");

        return username == "danny" && password == "123";

    }
}
