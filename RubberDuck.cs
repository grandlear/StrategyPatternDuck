using System;
using StrategyPatternDuck.QuackBehavior;
using StrategyPatternDuck.FlyBehavior;

namespace StrategyPatternDuck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new Squeak());
        }

        public override void Display()
        {
            Console.WriteLine("I am a rubber duck.");
        }
    }
}
