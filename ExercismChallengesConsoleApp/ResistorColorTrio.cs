using System;

public static class ResistorColorTrio
{
    public static string[] strings = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    public static string Label(string[] colors)
    {
        
        if(colors.Length < 3 || colors.Length > 3)
        {
            throw new ArgumentException("Incorrect number of colors");
        }

        ref string color1 = ref colors[0];
        ref string color2 = ref colors[1];
        ref string color3 = ref colors[2];

        string firstDigit = $"{(int)Array.IndexOf(strings, color1)}";
        string secondDigit = $"{(int)Array.IndexOf(strings, color2)}";
        string zeros = new string('0', (int)Array.IndexOf(strings, color3));
        string prefix = "";

        int total = int.Parse($"{firstDigit}{secondDigit}{zeros}");

        if(total >= 1000)
        {
            prefix = "kilo";
            total /= 1000;
        }

        return $"{total} {prefix}ohms";
    }
}