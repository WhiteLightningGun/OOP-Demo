namespace Polygons;

public class EquilateralTriangle(double sideLength) : Polygon(sideLength), IPolygon
{
    private double AreaCoefficient { get; } = Math.Sqrt(3) / 4;
    public override double Area => AreaCoefficient * Math.Pow(SideLength, 2);
    public override uint NumberOfSides {get; } = 3;
    public override string PolygonName { get; } = $"Equilateral Triangle";
    public override double Perimeter => 3 * SideLength;
}