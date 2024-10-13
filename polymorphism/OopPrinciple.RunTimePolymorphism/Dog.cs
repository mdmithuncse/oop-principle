namespace OopPrinciple.RunTimePolymorphism
{
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine($"{nameof(Dog)} barks, Woof!");
        }
    }
}
