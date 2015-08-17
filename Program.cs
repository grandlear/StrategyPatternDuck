using System;

namespace StrategyPatternDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my land of ducks.");

            Duck redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.Quack();
            redheadDuck.Swim();
            redheadDuck.Fly();

            Duck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Quack();
            mallardDuck.Swim();
            mallardDuck.Fly();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Quack();
            rubberDuck.Swim();
            rubberDuck.Fly();

            Duck userDuck = null;

            while (userDuck == null)
            {
                Console.WriteLine("What duck would you like to observe? Mallard, Redhead or Rubber?");
                var choice = Console.ReadLine().ToLower();

                switch (choice.Split(' ')[0])
                {
                    case "mallard":
                        userDuck = new MallardDuck();
                        break;
                    case "redhead":
                        userDuck = new RedheadDuck();
                        break;
                    case "rubber":
                        userDuck = new RubberDuck();
                        break;
                    default:
                        Console.WriteLine("Sorry, try again (spelling matters, so check carefully).");
                        break;
                }
            }

            userDuck.Display();
            userDuck.Quack();
            userDuck.Swim();
            userDuck.Fly();

            Console.WriteLine("Thanks for visiting.  Come back soon!");
            Console.ReadLine();
        }
    }
}
