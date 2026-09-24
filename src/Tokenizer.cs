using System.Text.RegularExpressions;

namespace Lokalculator;

public partial class Tokenizer
{
    
    public static string FetchEquation()
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
    
    public static List<string> TokenizeString(string sourceString)
    {
        List<string> Tokens = [];
        
        foreach (var match in MatchEquationToken().Matches(sourceString))
        {
            var token = match.ToString();
            Tokens.Add(token);
        }

        return Tokens;
    }
}