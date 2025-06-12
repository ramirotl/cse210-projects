using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        // Create a new Square object
        Square square = new Square("Red", 5.0);

        // Display the color and area of the square
        // Console.WriteLine($"Square Color: {square.GetColor()}");
        // Console.WriteLine($"Square Area: {square.GetArea()}");

        // Console.WriteLine();
        // Create a new Circle object
        Circle circle = new Circle("Blue", 3.0);
        // Console.WriteLine($"Circle Color: {circle.GetColor()}");
        // Console.WriteLine($"Circle Area: {circle.GetArea()}");

        // Console.WriteLine();
        // Create a new Rectangle object
        Rectangle rectangle = new Rectangle("Green", 4.0, 6.0);
        // Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");
        // Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");


        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of: {shape.GetArea()}");
            // Console.WriteLine($"Shape Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}