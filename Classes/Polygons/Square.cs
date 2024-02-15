namespace Polygons;

public class Square(double sideLength) : Polygon(sideLength), IPolygon
{
    public override double Area => Math.Pow(SideLength, 2);
    public override uint NumberOfSides {get; } = 4;
    public override string PolygonName { get; } = $"Square";
    public override double Perimeter => 4 * SideLength;
} 