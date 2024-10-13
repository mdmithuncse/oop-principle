namespace OopPrinciple.Inheritence
{
    public class Apple : Fruit
    {
        public DateTime PackageDate { get; set; }
        public string PackageName { get; set; }

        public void DisplayDerivedMessage()
        {
            Console.WriteLine($"Greetings from {nameof(Apple)} derived class." +
                              $"Name: {Name}, " +
                              $"Package Date: {PackageDate}, " +
                              $"Package Name: {PackageName}");
        }
    }
}
