//https://exercism.org/tracks/csharp/exercises/high-scores/edit

using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> scores = new List<int>();
    public HighScores(List<int> list)
    {
        scores = list;
    }

    public List<int> Scores()
    {
        return scores;
    }

    public int Latest()
    {
        return scores.Last();
    }

    public int PersonalBest()
    {
        return scores.Max();
    }

    public List<int> PersonalTopThree()
    {
        var rankedScores = scores.OrderByDescending(x => x).ToList();
        return rankedScores.Take(3).ToList();
    }
}