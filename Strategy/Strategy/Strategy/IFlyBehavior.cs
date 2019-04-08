using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public interface IFlyBehavior
    {
        void Flying();
    }

    public class NotFly : IFlyBehavior
    {
        public void Flying()
        {
            Console.WriteLine("Not fly");
        }
    }

    public class Fly: IFlyBehavior
    {
        public void Flying()
        {
            Console.WriteLine("Fly");
        }
    }
}
