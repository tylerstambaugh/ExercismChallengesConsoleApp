using System;
using System.Collections.Generic;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;


//https://exercism.org/tracks/csharp/exercises/land-grab-in-space/edit
public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }

    public static bool operator >(Coord c1, Coord c2)
    {
        return c1.X > c2.X && c1.Y > c2.Y;
    }

    public static bool operator <(Coord c1, Coord c2)
    {
        return !(c1 > c2);
    }
}

public struct Plot
{
    // TODO: Complete implementation of the Plot struct
    public Plot(Coord a, Coord b, Coord c, Coord d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }

    public Coord A { get; }
    public Coord B { get; }
    public Coord C { get; }
    public Coord D { get; }

    public static bool operator >(Plot p1, Plot p2)
    {
        return p1.A > p2.A && p1.B > p2.B && p1.C > p2.C && p1.D > p2.D;
    }


    public static bool operator <(Plot p1, Plot p2)
    {
        return !(p1 > p2);
    }
}


public class ClaimsHandler
{
    private List<Plot> _plots = new List<Plot>();
    private Plot _lastPlot;

    public void StakeClaim(Plot plot) => _plots.Add(plot);

    public bool IsClaimStaked(Plot plot) => _plots.Contains(plot);

    public bool IsLastClaim(Plot plot)
    {
        return _plots.Last().GetHashCode() == plot.GetHashCode();
    }

    public Plot GetClaimWithLongestSide()
    {
        Plot maxPlot = _lastPlot;
        foreach (var plot in _plots)
        {
            return plot;
            if (plot > maxPlot)
            {
                maxPlot = plot;
            }
        }
        return maxPlot;
    }
}
