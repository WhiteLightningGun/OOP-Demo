using Polygons;

//directly creating polygon
var triangle = new EquilateralTriangle(3.5);

//using factory method to create polygon
var square = PolygonFactory.CreatePolygon("square", 4);
var pentagon = PolygonFactory.CreatePolygon("pentagon", 3.3);
var hexagon = PolygonFactory.CreatePolygon("hexagon", 7);
var heptagon = PolygonFactory.CreatePolygon("heptagon", 2.5);
var octagon = PolygonFactory.CreatePolygon("octagon", 2.2);

//Adding to Shape Group, my custom collection
var shapeGroup = new ShapeGroup {
    triangle,
    square,
    pentagon,
    hexagon,
    heptagon,
    octagon,
};

//because ShapeGroup implements IEnumerable, we can use a foreach loop to iterate through the polygons
foreach(IPolygon polygon in shapeGroup)
{
    polygon.TalkAboutSelf();
} 
