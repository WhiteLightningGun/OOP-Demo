namespace Polygons;

public class Hexagon(double sideLength) : Polygon(sideLength), IPolygon
{
    public override double Area => 2.598076211353316 * Math.Pow(SideLength, 2);
    public override uint NumberOfSides {get; } = 6;
    public override string PolygonName { get; } = $"Hexagon";
    public override double Perimeter => 6 * SideLength;
}