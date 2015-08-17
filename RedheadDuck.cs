﻿using System;
using StrategyPatternDuck.FlyBehavior;
using StrategyPatternDuck.QuackBehavior;

namespace StrategyPatternDuck
{
    public class RedheadDuck : Duck
    {
        private IFlyBehavior _FlyBehavior;
        private IQuackBehavior _QuackBehavior;
        public override void Display()
        {
            Console.WriteLine("I am a redhead duck.");
        }
        public override void PerformFly()
        {
            this._FlyBehavior = new FlyWithWings();
            this._FlyBehavior.Fly();
        }

        public override void PerformQuack()
        {
            this._QuackBehavior = new QuackQuack();
            this._QuackBehavior.Quack();
        }
    }
}
