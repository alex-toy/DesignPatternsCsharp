namespace ChainOfResponsability.Good;

public class WebServer
{
    public required Handler Handler { get; set; }

    public void Handle(HttpRequest request)
    {
        Handler.Handle(request);
    }
}
