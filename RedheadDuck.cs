using System;
using StrategyPatternDuck.FlyBehavior;
using StrategyPatternDuck.QuackBehavior;

namespace StrategyPatternDuck
{
    public class RedheadDuck : Duck
    {

        public RedheadDuck()
        {
            SetFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new QuackQuack());
        }
        public override void Display()
        {
            Console.WriteLine("I am a redhead duck.");
        }
    }
}
