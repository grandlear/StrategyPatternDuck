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
            redheadDuck.PerformQuack();
            redheadDuck.Swim();
            redheadDuck.PerformFly();

            Duck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();
            mallardDuck.PerformFly();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformQuack();
            rubberDuck.Swim();
            rubberDuck.PerformFly();

            Duck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformQuack();
            decoyDuck.Swim();
            decoyDuck.PerformFly();

            Duck userDuck = null;

            while (userDuck == null)
            {
                Console.WriteLine("What duck would you like to observe? Mallard, Redhead, Rubber or Decoy?");
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
                    case "decoy":
                        userDuck = new DecoyDuck();
                        break;
                    default:
                        Console.WriteLine("Sorry, try again (spelling matters, so check carefully).");
                        break;
                }
            }

            userDuck.Display();
            userDuck.PerformQuack();
            userDuck.Swim();
            userDuck.PerformFly();

            Console.WriteLine("Thanks for visiting.  Come back soon!");
            Console.ReadLine();
        }
    }
}
