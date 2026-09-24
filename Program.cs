using Lokalculator;

Tokenizer tokenizer = new Tokenizer();
Postfix postfix = new Postfix();
Calculate calculate = new Calculate();

string equation = tokenizer.FetchEquation();
List<string> tokens = tokenizer.TokenizeString(equation);

List<string> postfixNotation = postfix.Sort(tokens);
Console.WriteLine($"Postfix notation: {string.Join(" ", postfixNotation)}");

double result = calculate.PerformCalculation(postfixNotation);
Console.WriteLine($"The result is: {result}");