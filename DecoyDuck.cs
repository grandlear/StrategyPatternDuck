using System;
using StrategyPatternDuck.FlyBehavior;
using StrategyPatternDuck.QuackBehavior;

namespace StrategyPatternDuck
{
    public class DecoyDuck : Duck
    {
        private IFlyBehavior _FlyBehavior;
        private IQuackBehavior _QuackBehavior;
        public override void Display()
        {
            Console.WriteLine("I am a wooden decoy duck.");
        }
        public override void PerformQuack()
        {
            this._QuackBehavior = new MuteQuack();
            this._QuackBehavior.Quack();
        }
        public override void PerformFly()
        {
            this._FlyBehavior = new FlyNoWay();
            this._FlyBehavior.Fly();
        }
    }
}
