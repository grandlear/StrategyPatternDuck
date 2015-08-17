using System;
using StrategyPatternDuck.QuackBehavior;
using StrategyPatternDuck.FlyBehavior;

namespace StrategyPatternDuck
{
    public class RubberDuck : Duck
    {
        private IQuackBehavior _QuackBehavior;
        private IFlyBehavior _FlyBehavior;
        public override void Display()
        {
            Console.WriteLine("I am a rubber duck.");
        }
        public override void PerformQuack()
        {
            this._QuackBehavior = new Squeak();
            this._QuackBehavior.Quack();
        }
        public override void PerformFly()
        {
            this._FlyBehavior = new FlyNoWay();
            this._FlyBehavior.Fly();
        }
    }
}
