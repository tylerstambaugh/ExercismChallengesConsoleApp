using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number == 1)
            return Classification.Deficient;

        if (number <= 0)
            throw new ArgumentOutOfRangeException();

        var factors = GetFactors(number);
        var list = factors.Take(factors.Count - 1);
       

        var sum = list.Sum();

        if (sum == number)
            return Classification.Perfect;
        if (sum < number)
            return Classification.Deficient;
        return Classification.Abundant;

    }

    static List<int> GetFactors(int number)
    {
        List<int> factors = new List<int>();

        for (int i = 1; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                factors.Add(i);

                if (i != number / i)
                {
                    factors.Add(number / i);
                }
            }
        }

        factors.Sort();
        return factors;
    }
}
