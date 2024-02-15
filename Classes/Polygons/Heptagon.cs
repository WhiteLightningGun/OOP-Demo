namespace Polygons;

public class Heptagon(double sideLength) : Polygon(sideLength), IPolygon
{
    public override double Area => 3.633912444001589 * Math.Pow(SideLength, 2);
    public override uint NumberOfSides {get; } = 7;
    public override string PolygonName { get; } = $"Heptagon";
    public override double Perimeter => 7 * SideLength;
}