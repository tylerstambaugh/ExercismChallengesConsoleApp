using System.Runtime.CompilerServices;

public static class Sieve
{
    private static Dictionary<int, bool> _list = new Dictionary<int, bool>();
    public static int[] Primes(int limit)
    {
        List<int> returnList = new List<int>();

        //create dict up to limit
        
        for(int i = 1; i < limit; i++)
        {
           _list.Add(i, true);
        }

        int nextPrime = 1;
        while(nextPrime < limit)
        {
            nextPrime = _list.FirstOrDefault(x => x.Key > 1 && x.Value).Key;

            for(int i = nextPrime; i < limit; i *= nextPrime)
            {
                _list[i] = false;
            }
        }

        foreach(int i in _list.Keys)
        {
            if(i.Equals(true))
            {
                returnList.Add(i);
            }
        }

        return returnList.ToArray();
    }
}