using Polygons;
public static class PolygonFactory
{
    /// <summary>
    /// Factory method to create a polygon of the specified type with the specified side length.
    /// </summary>
    /// <param name="polygonType">Possible string arguments: triangle, square, pentagon, hexagon, heptagon, octagon.</param>
    /// <param name="sideLength">Must be greater than 0.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static IPolygon CreatePolygon(string polygonType, double sideLength)
    {
        switch (polygonType.ToLower())
        {
            case "triangle":
                return new EquilateralTriangle(sideLength);
            case "square":
                return new Square(sideLength);
            // Add more cases as needed for other polygon types
            case "pentagon":
                return new Pentagon(sideLength);
            case "hexagon":
                return new Hexagon(sideLength);
            case "heptagon":
                return new Heptagon(sideLength);
            case "octagon":
                return new Octagon(sideLength);
            default:
                throw new ArgumentException("Invalid polygon type.");
        }
    }
}