using System;
using System.Text.RegularExpressions;

class RegularExpressionExample
{
    public static string ExtractTextBetweenColons(string input)
    {
        string pattern = ":(.*?):";

        // Regex with Singleline option (so '.' matches newline too)
        Regex rgxLookup = new Regex(pattern, RegexOptions.Singleline);

        Match match = rgxLookup.Match(input);

        // Return group 1 if match is successful
        return match.Success ? match.Groups[1].Value : "No match found";
    }
}
