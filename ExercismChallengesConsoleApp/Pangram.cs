//https://exercism.org/tracks/csharp/exercises/pangram/edit

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        Dictionary<string, int> chars = new Dictionary<string, int>();
        string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        foreach(string s in alphabet)
        {
            chars.Add(s, 0);
        }

        string lowerCaseInput = input.ToLower();

        for (int i = 0; i < lowerCaseInput.Length; i++)
        {
            if (chars.ContainsKey(lowerCaseInput[i].ToString()))        
                chars[lowerCaseInput[i].ToString()] ++;            
        }

        if (chars.ContainsValue(0))
            return false;
        return true;
    }
}
