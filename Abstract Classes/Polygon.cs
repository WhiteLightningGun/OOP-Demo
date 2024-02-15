namespace Polygons;

/// <summary>
/// Intended to demonstrate polymorphism, encapsulation and abstract classes.
/// </summary>
public abstract class Polygon : IPolygon
{
    private double sideLength;
    public Polygon(double sideLength)
    {
        SideLength = sideLength;
    }
    public double SideLength
    {
        get
        {
            return this.sideLength;
        }
        set
        {
            SetSideLength(value);
        }
    }
    private void SetSideLength(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Side length must be positive.");
        }
        sideLength = value;
    }
    public abstract double Area { get; }
    public abstract double Perimeter { get; }
    public abstract uint NumberOfSides { get;}
    public abstract string PolygonName { get; }
    public virtual void TalkAboutSelf()
    {
        Console.WriteLine($"I am {PolygonName} with {NumberOfSides} sides.");
        Console.WriteLine($"I have an area of {Area} and a perimeter of {Perimeter}.\n");
    }
}