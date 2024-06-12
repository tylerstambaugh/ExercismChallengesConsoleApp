using System;
using System.Collections.Generic;
using System.Linq;

public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
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

}


public class ClaimsHandler
{
    private List<Plot> _plots = new List<Plot>();
    public void StakeClaim(Plot plot)
    {
        _plots.Add(plot);
    }

    public bool IsClaimStaked(Plot plot)
    {
        return _plots.Contains(plot);
    }

    public bool IsLastClaim(Plot plot)
    {
       return _plots.Last().GetHashCode() == plot.GetHashCode();   
    }

    public Plot GetClaimWithLongestSide()
    {
        Plot longestSidedPlot;
        int aDiff = 0;
        int bDiff = 0;
        int cDiff = 0;
        int dDiff = 0;

       foreach(Plot plot in _plots)
        {
            aDiff = Math.Abs(plot.A.X - plot.B.X);
            bDiff = Math.Abs(plot.B.X - plot.C.X);
            cDiff = Math.Abs(plot.C.X - plot.D.X);
            dDiff = Math.Abs(plot.D.X - plot.A.X);
        }

        return longestSidedPlot;
    }
}
