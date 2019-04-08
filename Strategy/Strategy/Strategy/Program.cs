using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck firstDuck = new RedDuck("Robby", 1, new Fly());
            Duck secondDuck = new WoodenDuck("Billy", 13, new NotFly());

            firstDuck.Fly();
            secondDuck.Fly();

            Console.ReadKey();
        }
    }
}
