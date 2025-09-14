namespace OopPrinciple.CompileTimePolymorphism
{
    internal interface ICalculator
    {
        int Addition(int a, int b);
        int Addition(int a, int b, int c);
        int Addition(int a, int b, int c, int d);

        int Subtraction(int a, int b);
        int Subtraction(int a, int b, int c);
        int Subtraction(int a, int b, int c, int d);
    }
}
