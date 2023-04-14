using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> dic = (Dictionary<char, int>)CreateEmtpyDictionary();

        string sequenceToCheck = sequence.ToUpper().Trim();

        foreach (char c in sequenceToCheck)
        {
            if(dic.ContainsKey(c))
                dic[c] += 1;

        }

        return dic;
    }

    private static  IDictionary<char, int> CreateEmtpyDictionary()
    {
        return new Dictionary<char, int>()
        {
            { 'A', 0 },
            { 'C', 0 },
            { 'G', 0 },
            { 'T' ,0 }
        };
    }
}