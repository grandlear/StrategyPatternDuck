using System;

namespace StrategyPatternDuck
{
    public abstract class Duck
    {
        IFlyBehavior _flyBehavior;
        IQuackBehavior _quackBehavior;

        public abstract void Display();
        public void PerformFly()
        {
            _flyBehavior.Fly();
        }
        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }
        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }
        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }
        public void Swim()
        {
            Console.WriteLine("Swimming ever so elegantly...");
        }
    }
}
