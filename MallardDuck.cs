using System;

namespace StrategyPatternDuck
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a mallard duck.");
        }
    }
}
