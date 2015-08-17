using System;

namespace StrategyPatternDuck
{
    public abstract class Duck
    {
        public abstract void Display();
        public abstract void PerformFly();
        public abstract void PerformQuack();
        public void Swim()
        {
            Console.WriteLine("Swimming ever so elegantly...");
        }
    }
}
