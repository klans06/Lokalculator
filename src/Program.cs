using Lokalculator;

string equation = Tokenizer.FetchEquation();
List<string> tokens = Tokenizer.TokenizeString(equation);

List<string> postfixNotation = Postfix.Sort(tokens);
Console.WriteLine($"Postfix notation: {string.Join(" ", postfixNotation)}");

double result = Calculate.PerformCalculation(postfixNotation);
Console.WriteLine($"The result is: {result}");