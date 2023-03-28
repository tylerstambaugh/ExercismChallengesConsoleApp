//https://exercism.org/tracks/csharp/exercises/isogram

using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string wordToCheck = word.ToLower().Trim().Replace("-", "").Replace(" ", "");
        Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
        bool returnBool = true;
        foreach (char c in wordToCheck)
        {
            
            if (!keyValuePairs.ContainsKey(c))
            {                
                keyValuePairs.Add(c, 1);
            }
            else
            {
                returnBool = false;
            }
        }
        return returnBool;
    }
}
