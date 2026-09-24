using System.Text.RegularExpressions;

namespace Lokalculator;

public partial class Tokenizer
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
    
    [GeneratedRegex(@"\d+(\.\d+)?|[+\-*/()]", RegexOptions.IgnoreCase, "en-US")]
    private static partial Regex MatchEquationToken();
    
    public List<string> TokenizeString(string sourceString)
    {
        foreach (var match in MatchEquationToken().Matches(sourceString))
        {
            var token = match.ToString();
            Tokens.Add(token);
        }

        return Tokens;
    }
    
    // private bool CheckToken(string token)
    // {
    //     if (double.TryParse(token, out _))
    //     {
    //         return true;
    //     } else if (OperatorRegistry.Operators.ContainsKey(token))
    //     {
    //         return true;
    //     } else if (token is "(" or ")")
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }
}