namespace OopPrinciple.CompileTimePolymorphism
{
    internal class Calculator : ICalculator
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Addition(int a, int b, int c)
        {
            return Addition(a, b) + c;
        }

        public int Addition(int a, int b, int c, int d)
        {
            return Addition(a, b, c) + d;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Subtraction(int a, int b, int c)
        {
            return Subtraction(a, b) - c;
        }

        public int Subtraction(int a, int b, int c, int d)
        {
            return Subtraction(a, b, c) - d;
        }
    }
}
