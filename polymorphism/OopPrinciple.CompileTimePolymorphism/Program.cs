// See https://aka.ms/new-console-template for more information
using OopPrinciple.CompileTimePolymorphism;

Console.WriteLine("Hello, This is an example of compile-time polymorphism concept.");

Calculator calculator = new Calculator();

Console.WriteLine($"First method addition: { calculator.Addition(10, 20) }");
Console.WriteLine($"Second method addition: {calculator.Addition(10, 20, 30)}");
Console.WriteLine($"Third method addition: {calculator.Addition(10, 20, 30, 40)}");

Console.WriteLine();

Console.WriteLine($"First method subtraction: {calculator.Subtraction(20, 10)}");
Console.WriteLine($"Second method subtraction: {calculator.Subtraction(40, 20, 10)}");
Console.WriteLine($"Third method subtraction: {calculator.Subtraction(60, 20, 10, 10)}");