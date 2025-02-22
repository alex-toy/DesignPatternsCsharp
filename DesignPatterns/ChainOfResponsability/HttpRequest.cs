namespace ChainOfResponsability;

public class HttpRequest
{
    private string _username;
    private string _password;
    public string ValidatedUsername { get; set; } = "";
    public string ValidatedPassword { get; set; } = "";


    public HttpRequest(string username, string password)
    {
        _username = username;
        _password = password;
    }

    public string GetUsername()
    {
        return _username;
    }

    public string GetPassword()
    {
        return _password;
    }
}
