namespace ChainOfResponsability.Good;

public class Authenticator : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();
        Console.WriteLine($"{username} - {password} authenticated");
        return !(username == "danny" && password == "123");
    }
}
