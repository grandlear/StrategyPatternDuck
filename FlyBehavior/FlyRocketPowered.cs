using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDuck.FlyBehavior
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Hmm...what does this 'On' button do?\n\t\tHOOOOOOOOOLLLLLYYYYY SMOKES!!! I'm flying by rocket!!!");
        }
    }
}
