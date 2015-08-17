using System;
using StrategyPatternDuck.FlyBehavior;
using StrategyPatternDuck.QuackBehavior;

namespace StrategyPatternDuck
{
    public class RedheadDuck : Duck
    {
        private IFlyBehavior _flyBehavior = new FlyWithWings();
        private IQuackBehavior _quackBehavior = new QuackQuack();
        public override void Display()
        {
            Console.WriteLine("I am a redhead duck.");
        }
        public override void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public override void PerformQuack()
        {
            _quackBehavior.Quack();
        }
    }
}
