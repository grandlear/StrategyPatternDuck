using System;
using StrategyPatternDuck.FlyBehavior;
using StrategyPatternDuck.QuackBehavior;

namespace StrategyPatternDuck
{
    public class DecoyDuck : Duck
    {
        private IFlyBehavior _flyBehavior = new FlyNoWay();
        private IQuackBehavior _quackBehavior = new MuteQuack();
        public override void Display()
        {
            Console.WriteLine("I am a wooden decoy duck.");
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
