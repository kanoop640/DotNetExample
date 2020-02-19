using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExample
{
    interface IMathComputation
    {
        // we can't declare any fields/variables under an interface
        void Add(int x, int y);
        void Sub(int a, int b);
    }
}
