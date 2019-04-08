using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class RedDuck : Duck
    {
        public RedDuck(string name, int old, IFlyBehavior flyBehavior) : base(name, old, flyBehavior)
        {
        }
    }
}
