namespace Lokalculator;

public class Calculate
{
    public static double PerformCalculation(List<string> infixEquation)
    {
        Stack<double> result = [];

        void Calculate(double firstOperand, double secondOperand, char op)
        {
            switch (op)
            {
                case '+':
                    result.Push(firstOperand + secondOperand);
                    break;
                case '-':
                    result.Push(secondOperand - firstOperand);
                    break;
                case '/':
                    result.Push(secondOperand / firstOperand);
                    break;
                case '*':
                    result.Push(firstOperand * secondOperand);
                    break;
            }
        }

        foreach (var token in infixEquation)
        {
            if (double.TryParse(token, out double number))
            {
                result.Push(number);
            } else if (OperatorRegistry.Operators.ContainsKey(token))
            {
                char op = token[0];
                Calculate(result.Pop(), result.Pop(), op);
            }
        }

        return result.Peek();
    }
}