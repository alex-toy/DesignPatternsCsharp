namespace ChainOfResponsability.Generic.Structure;

public abstract class Handler<T>
{
    public required Handler<T>? Next { get; set; }

    public Handler<T> SetNext(Handler<T> next) { Next = next; return next; }

    public void Handle(T request)
    {
        if (DoHandle(request)) return;

        if (Next is not null) Next.Handle(request);
    }

    public abstract bool DoHandle(T request);
}
