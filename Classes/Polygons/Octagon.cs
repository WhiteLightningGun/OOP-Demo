namespace Polygons;

public class Octagon(double sideLength) : Polygon(sideLength), IPolygon
{
    public override double Area => 4.82842712474619 * Math.Pow(SideLength, 2);
    public override uint NumberOfSides {get; } = 8;
    public override string PolygonName { get; } = $"Octagon";
    public override double Perimeter => 8 * SideLength;
}