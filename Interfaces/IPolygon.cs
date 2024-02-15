namespace Polygons;

public interface IPolygon
{
    public double Area { get; }
    public double SideLength { get; }
    public double Perimeter { get; }
    public uint NumberOfSides { get; }
    public string PolygonName { get; }
    public void TalkAboutSelf();
}