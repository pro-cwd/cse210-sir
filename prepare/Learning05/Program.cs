using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Blue", 3);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Black", 4, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Green", 6);
        shapes.Add(shape3);

        foreach (Shape shp in shapes)
        {
            string color = shp.GetColor();
            double area = shp.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}