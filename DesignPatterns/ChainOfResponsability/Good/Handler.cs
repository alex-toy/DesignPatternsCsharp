namespace ChainOfResponsability.Good;

public abstract class Handler
{
    public required Handler? Next { get; set; }

    public Handler SetNext(Handler next) {  Next = next; return next;  }

    public void Handle(HttpRequest request)
    {
        if (DoHandle(request)) return;

        if (Next is not null) Next.Handle(request);
    }

    public abstract bool DoHandle(HttpRequest request);
}
