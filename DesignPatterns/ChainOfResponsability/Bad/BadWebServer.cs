namespace ChainOfResponsability.Bad;

public class BadWebServer
{
    public void Handle(HttpRequest request)
    {
        var validator = new BadValidator();
        validator.Validate(request);

        var authenticator = new BadAuthenticator();
        authenticator.Authenticate(request);

        var logger = new BadLogger();
        logger.Log(request);
    }
}
