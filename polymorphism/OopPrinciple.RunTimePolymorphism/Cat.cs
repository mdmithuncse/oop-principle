namespace OopPrinciple.RunTimePolymorphism
{
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine($"{nameof(Cat)} barks, Meow!");
        }
    }
}
