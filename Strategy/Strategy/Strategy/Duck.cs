using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public abstract class Duck
    {
        public string Name { get; }
        public int Old { get; }

        public IFlyBehavior FlyBehavior { get; set; }

        public Duck(string name, int old, IFlyBehavior flyBehavior)
        {
            Name = name;
            Old = old;
            FlyBehavior = flyBehavior;
        }

        public void Fly()
        {
            FlyBehavior.Flying();
        }


    }
}
