using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExample
{
    class MathFunction
    {
        int a, b;
        public MathFunction(int x, int y)
        {
            this.a = x;
            this.b = y;
        }
        public int Addition()
        {
            return this.a + this.b;
        }
        public double Division()
        {
            return a / b;
        }
    }
}

