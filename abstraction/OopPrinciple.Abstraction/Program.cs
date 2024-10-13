// See https://aka.ms/new-console-template for more information
using OopPrinciple.Abstraction;

Console.WriteLine("Hello, This is an example of abstraction concept.");

Circle circle = new Circle(5);
Console.WriteLine($"Area of circle: {circle.CalculateArea()}");

Rectangle rectangle = new Rectangle(10, 5);
Console.WriteLine($"Area of rectangle: {rectangle.CalculateArea()}"); ;