namespace Interpretor;

public static class Extensions
{
    public const string PLUS = "+";
    public const string MINUS = "-";
    public const string TIMES = "*";

    public static bool IsOperator(this string operatorName)
    {
        return operatorName == PLUS || operatorName == MINUS || operatorName == TIMES;
    }
}
