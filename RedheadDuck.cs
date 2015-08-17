using System;

namespace StrategyPatternDuck
{
    public class RedheadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a redhead duck.");
        }
    }
}
