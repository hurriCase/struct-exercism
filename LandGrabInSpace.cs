using System;

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
    private int _x;
    private int _y;
    public Plot(int x, int y)
    {
        this._x = x;
        this._y = y;
    }
}


public class ClaimsHandler
{
    public void StakeClaim(Plot plot)
    {
        throw new NotImplementedException("Please implement the ClaimsHandler.StakeClaim() method");
    }

    public bool IsClaimStaked(Plot plot)
    {
        throw new NotImplementedException("Please implement the ClaimsHandler.IsClaimStaked() method");
    }

    public bool IsLastClaim(Plot plot)
    {
        throw new NotImplementedException("Please implement the ClaimsHandler.IsLastClaim() method");
    }

    public Plot GetClaimWithLongestSide()
    {
        throw new NotImplementedException("Please implement the ClaimsHandler.GetClaimWithLongestSide() method");
    }
}
