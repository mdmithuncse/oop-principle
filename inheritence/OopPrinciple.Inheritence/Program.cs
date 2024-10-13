// See https://aka.ms/new-console-template for more information
using OopPrinciple.Inheritence;

Console.WriteLine("Hello, This is an example of inheritence concept.");

Apple apple = new Apple
{
    Name = nameof(Apple),
    PackageDate = DateTime.UtcNow,
    PackageName = $"Package of {nameof(Apple)}"
};

apple.DisplayBaseMessage();
apple.DisplayDerivedMessage();