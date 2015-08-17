using System;

namespace StrategyPatternDuck
{
    public class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Squeak, squeak...");
        }

        public override void Display()
        {
            Console.WriteLine("I am a rubber duck.");
        }

        public override void Fly()
        {
            Console.WriteLine("Unfortunately, this duck cannot fly.");
        }
    }
}
