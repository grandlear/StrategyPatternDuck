using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDuck
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a wooden decoy duck.");
        }

        public override void Quack()
        {
            Console.WriteLine("This duck cannot quack.");
        }

        public override void Fly()
        {
            Console.WriteLine("Unfortunately, this duck cannot fly.");
        }
    }
}
