using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class WoodenDuck : Duck
    {
        public WoodenDuck(string name, int old, IFlyBehavior flyBehavior) : base(name, old, flyBehavior)
        {
        }
    }
}
