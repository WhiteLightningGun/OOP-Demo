# Polymorphism for Polygons!

### A console app to quickly demo object oriented programming in C# .Net.

Starts by implementing an abstract "Polygon" class using an interface called IPolygon, from which I inherit to create multiple different classes representing all the low-order polygons. Obviously in mathematics all the regular convex polygons are extremely similar following simple rules, yet they all have sufficiently different numerical characteristics such that it is possible to use a different methods for each shape. This presents an opportunity to use polymorphism in the form of class inheritance and overriding the basic properties from Polygon class. It means that when these properties are accessed on an inherited class object, the class specific versions of these properties are used, even when the object is accessed through a reference of type Polygon.

The second half of the project consists of the ShapeGroup class. This implements the IEnumerable interface and uses the generic type defined by Polygon, this means it can hold collections of objects that implement the Polygon and IPolygon requirements. It can be iterated with like any other collection. It encapsulates the logic for holding polygon objects. 
