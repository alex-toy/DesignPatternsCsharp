namespace Interpretor;

public class AdditionExpression : IExpression
{
    private IExpression _left;
    private IExpression _right;

    public AdditionExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public int Interpret(Context context)
    {
        return _left.Interpret(context) + _right.Interpret(context);
    }
}
