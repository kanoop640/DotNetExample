using System;

namespace DotNetExample
{
    class ImplementationClass : IMathComputation1
    {
        public int Add(int x, int y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
