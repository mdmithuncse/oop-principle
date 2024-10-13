namespace OopPrinciple.Inheritence
{
    public class Fruit
    {
        public string Name { get; set; }

        public void DisplayBaseMessage()
        {
            Console.WriteLine($"Greetings from {nameof(Fruit)} base class.");
        }
    }
}
