using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDuck.QuackBehavior
{
    public class QuackQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack, quack...");
        }
    }
}
