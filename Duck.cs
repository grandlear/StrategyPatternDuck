using System;

namespace StrategyPatternDuck
{
    public abstract class Duck
    {
        public abstract void Display();

        public virtual void Fly()
        {
            Console.WriteLine("Flying and flying...");
        }
        public virtual void Quack()
        {
            Console.WriteLine("Quack quack...");
        }
        public void Swim()
        {
            Console.WriteLine("Swimming ever so elegantly...");
        }
        

    }
}
