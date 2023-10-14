using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        Dictionary<int, bool> _list = new Dictionary<int, bool>();
        List<int> returnList = new List<int>();

        //create dict up to limit
        if (limit < 0)
        {
            throw new ArgumentOutOfRangeException("limit");
        }
        else
        {
            for (int i = 2; i <= limit; i++)
            {
                _list.Add(i, false);
            }

            for (int i = 2; i <= limit; i++)
            {
                if (_list[i] == false)
                {
                    _list[i] = true;
                    returnList.Add(i);

                    for (int j = 1; j * i <= limit; j++)
                    {
                        _list[j * i] = true;
                    }
                }
            }

            return returnList.ToArray();
        }
    }
}