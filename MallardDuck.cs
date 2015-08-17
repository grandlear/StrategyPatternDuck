using System;
using StrategyPatternDuck.FlyBehavior;
using StrategyPatternDuck.QuackBehavior;

namespace StrategyPatternDuck
{
    public class MallardDuck : Duck
    {
        private IFlyBehavior _flyBehavior = new FlyWithWings();
        private IQuackBehavior _quackBehavior = new QuackQuack();
        public override void Display()
        {
            Console.WriteLine("I am a mallard duck.");
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
