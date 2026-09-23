namespace Lokalculator;

public class Postfix
{
    public List<string> Sort(List<string> tokens)
    {
        Stack<string> operatorStack = [];
        List<string> outputQueue = [];

        foreach (var token in tokens)
        {
            if (double.TryParse(token, out _))
            {
                outputQueue.Add(token);
            } else if (OperatorRegistry.Operators.ContainsKey(token))
            {
                while (operatorStack.Count() != 0 && operatorStack.Peek() != "(" &&
                       OperatorRegistry.Operators[operatorStack.Peek()] >= OperatorRegistry.Operators[token])
                {
                    outputQueue.Add(operatorStack.Pop());
                }
                operatorStack.Push(token);
            } else switch (token)
            {
                case "(":
                    operatorStack.Push(token);
                    break;
                case ")":
                {
                    while (operatorStack.Count() != 0 && operatorStack.Peek() != "(")
                    {
                        outputQueue.Add(operatorStack.Pop());
                    }

                    if (operatorStack.Peek() == "(")
                    {
                        operatorStack.Pop();
                    }

                    break;
                }
            }
        }

        while (operatorStack.Count() != 0)
        {
            outputQueue.Add(operatorStack.Pop());
        }

        return outputQueue;
    }
}