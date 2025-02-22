namespace ChainOfResponsability.Bad;

public class BadValidator
{
    public void Validate(HttpRequest request)
    {
        var username = request.GetUsername();
        var password = request.GetPassword();

        request.ValidatedUsername = username.Trim();
        request.ValidatedPassword = password.Trim();

        Console.WriteLine($"{request.ValidatedUsername} - {request.ValidatedPassword} validated");
    }
}
