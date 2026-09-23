namespace Lokalculator;

public static class OperatorRegistry
{
    public static readonly Dictionary<string, int> Operators = new()
    {
        { "/", 1 },
        { "*", 1 },
        { "+", 0 },
        { "-", 0 },
    };
}