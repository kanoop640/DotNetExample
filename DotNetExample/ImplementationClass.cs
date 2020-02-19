using System;

namespace DotNetExample
{
    class ImplementationClass :IMathComputation1
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine(a*b);
        }
    }
}
