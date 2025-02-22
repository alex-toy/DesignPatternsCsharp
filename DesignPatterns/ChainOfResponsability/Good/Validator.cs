namespace ChainOfResponsability.Good;

public class Validator : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();

        request.ValidatedUsername = username.Trim();
        request.ValidatedPassword = password.Trim();

        Console.WriteLine($"{request.ValidatedUsername} - {request.ValidatedPassword} validated");

        return request.ValidatedUsername == "" || request.ValidatedPassword == "";
    }
}
