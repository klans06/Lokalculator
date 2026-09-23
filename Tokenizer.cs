using System.Text.RegularExpressions;

namespace Lokalculator;

public class Tokenizer
{
    private List<string> Tokens = [];
    
    public string FetchEquation()
    {
        Console.WriteLine("Enter your equation:");
        string equation = Console.ReadLine();
        
        if (string.IsNullOrEmpty(equation))
        {
            Console.WriteLine("No equation provided.");
        }

        return equation;
    }
    
    public List<string> TokenizeString(string sourceString)
    {
        foreach (Match m in Regex.Matches(sourceString, @"\d+(\.\d+)?|[+\-*/()]"))
        {
            if (CheckToken(m.ToString()))
            {
                Tokens.Add(m.ToString());
            } else
            {
                Console.WriteLine($"{m.ToString()} is not an operator or number. Please fix equation.");
                return null;
            }
        }

        return Tokens;
    }
    
    private bool CheckToken(string token)
    {
        if (double.TryParse(token, out _))
        {
            return true;
        } else if (OperatorRegistry.Operators.ContainsKey(token))
        {
            return true;
        } else if (token is "(" or ")")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}