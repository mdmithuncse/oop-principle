// See https://aka.ms/new-console-template for more information
using OopPrinciple.RunTimePolymorphism;

Console.WriteLine("Hello, This is an example of polymorphism concept.");

IAnimal[] animals = { new Dog(), new Cat() };

foreach (IAnimal animal in animals)
{
    animal.MakeSound();
}