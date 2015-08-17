using System;
using StrategyPatternDuck.QuackBehavior;
using StrategyPatternDuck.FlyBehavior;

namespace StrategyPatternDuck
{
    public class RubberDuck : Duck
    {
        private IQuackBehavior _quackBehavior = new Squeak();
        private IFlyBehavior _flyBehavior = new FlyNoWay();
        public override void Display()
        {
            Console.WriteLine("I am a rubber duck.");
        }
        public override void PerformQuack()
        {
            _quackBehavior.Quack();
        }
        public override void PerformFly()
        {
            _flyBehavior.Fly();
        }
    }
}
