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

public struct Plot : IComparable<Plot>
{
    private Coord _leftTop;
    private Coord _rightTop;
    private Coord _rightBottom;
    private Coord _leftBottom;
    private int _perimeter;
    public Plot(Coord leftBottom, Coord rightBottom, Coord leftTop, Coord rightTop)
    {
        _leftBottom = leftBottom;
        _rightBottom = rightBottom;
        _leftTop = leftTop;
        _rightTop = rightTop;
        _perimeter = 
            (rightBottom.X - leftBottom.X) + 
            (rightTop.Y - rightBottom.Y) + 
            (rightTop.X - leftTop.X) +
            (leftTop.Y - leftBottom.Y);
    }
    public int CompareTo(Plot obj) => _perimeter.CompareTo(obj._perimeter);
}


public class ClaimsHandler
{
    private List<Plot> _claimedLand = new();
    public void StakeClaim(Plot plot) => _claimedLand.Add(plot);

    public bool IsClaimStaked(Plot plot) => _claimedLand.Contains(plot);

    public bool IsLastClaim(Plot plot) => _claimedLand.Last().Equals(plot);

    public Plot GetClaimWithLongestSide() => _claimedLand.Max();
}
