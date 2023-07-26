using System;
using System.Collections;

public static class FlattenArray
{
    public static List<int> returnArray = new List<int>();
    public static IEnumerable Flatten(IEnumerable input)
    {
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
        }
        return returnArray;
    }
}