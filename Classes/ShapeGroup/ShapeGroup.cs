using System.Collections;

namespace Polygons;

public class ShapeGroup : IEnumerable<IPolygon>
{
    public List<IPolygon> Polygons { get; } = [];

    //Collection Initialiser
    public void Add(IPolygon polygon)
    {
        if (polygon is not null)
        {
            Polygons.Add(polygon);
        }
        else
        {
            throw new ArgumentException("Only objects that implement IPolygon can be added to the ShapeGroup.");
        }
    }
    public IEnumerator<IPolygon> GetEnumerator()
    {
        return Polygons.GetEnumerator();
    }
    public void TalkAboutPolygons()
    {
        foreach (var polygon in Polygons)
        {
            polygon.TalkAboutSelf();
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}