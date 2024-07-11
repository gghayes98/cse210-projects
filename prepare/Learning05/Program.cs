using Learning05;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Blue", 4));
        shapes.Add(new Rectangle("Red", 3, 6));
        shapes.Add(new Circle("Yellow", 2));

        foreach(Shape shape in shapes) 
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}