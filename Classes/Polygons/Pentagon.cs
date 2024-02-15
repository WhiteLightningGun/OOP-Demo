namespace Polygons;

public class Pentagon(double sideLength) : Polygon(sideLength), IPolygon
{
    public override double Area => 1.720477400588967 * Math.Pow(SideLength, 2);
    public override uint NumberOfSides {get; } = 5;
    public override string PolygonName { get; } = $"Pentagon";
    public override double Perimeter => 5 * SideLength;
}