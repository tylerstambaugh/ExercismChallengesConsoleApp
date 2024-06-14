using System;
using System.Text;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] delimiters = new char[] { ' ', '-', '_'};
  
        var acronymList = phrase.Trim()
            .Split(delimiters)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Select(x => x.Trim())
            .Select(x => x.Substring(0, 1)
            .ToUpper())
            .ToList();
        return string.Concat(acronymList);
    }
}