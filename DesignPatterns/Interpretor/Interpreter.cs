namespace Interpretor;

public class Interpreter
{
    private Context _context;

    public Interpreter(Context context)
    {
        _context = context;
    }

    public int Interpret(string expression)
    {
        IExpression expressionTree = BuildExpressionTree(expression);
        return expressionTree.Interpret(_context);
    }

    private IExpression BuildExpressionTree(string input)
    {
        string[] tokens = input.Split(' ');
        Queue<string> output = new Queue<string>();
        Stack<string> operators = new Stack<string>();

        FillStacks(tokens, output, operators);

        while (operators.Count > 0)
        {
            output.Enqueue(operators.Pop());
        }

        var expressionStack = new Stack<IExpression>();

        while (output.Count > 0)
        {
            var token = output.Dequeue();

            if (int.TryParse(token, out int number))
            {
                expressionStack.Push(new NumberExpression(number));
            }
            else if (token.IsOperator())
            {
                var right = expressionStack.Pop();
                var left = expressionStack.Pop();

                IExpression expression = token switch
                {
                    Extensions.PLUS => new AdditionExpression(left, right),
                    Extensions.MINUS => new SubtractionExpression(left, right),
                    Extensions.TIMES => new MultiplicationExpression(left, right),
                    _ => throw new NotSupportedException()
                };

                expressionStack.Push(expression);
            }
        }

        return expressionStack.Pop();
    }

    private static void FillStacks(string[] tokens, Queue<string> output, Stack<string> operators)
    {
        foreach (var token in tokens)
        {
            if (int.TryParse(token, out _))
            {
                output.Enqueue(token);
            }
            else if (token.IsOperator())
            {
                while (operators.Count > 0 && operators.Peek().IsOperator())
                {
                    output.Enqueue(operators.Pop());
                }
                operators.Push(token);
            }
        }
    }
}
