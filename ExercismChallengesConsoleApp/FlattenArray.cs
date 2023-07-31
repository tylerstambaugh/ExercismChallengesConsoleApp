using System;
using System.Collections;

public static class FlattenArray
{
    public static List<int> returnArray = new List<int>();
    public static int count = 0;
    public static IEnumerable Flatten(IEnumerable input)
    {
        if(count == 0)
        {
            returnArray = new List<int> ();
        }
        foreach (var item in input)
        {
            if (item is object[] nestedArray)
            {
                Flatten(nestedArray);
            }
            else if(item != null && item is int)
            {
                returnArray.Add((int)item);
            }
            count++;
        }
        count = 0;
        return returnArray;
    }
}