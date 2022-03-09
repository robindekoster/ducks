using System;

using Ducks;

namespace Ducks
{
    class Program
    {          
        static void Main()
        {
            //Set variables.
            Boolean TestForKeys = true;
            //Create Animals.
            Duck mallard = new MallardDuck();
            Duck rubber = new RubberDuck();

            //Show welcome text.
            Text.WelcomeText();

            while (TestForKeys == true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                if ((result.KeyChar == 'q') || (result.KeyChar == 'Q'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou pressed: '" + result.KeyChar + "'. Quitting...");
                    Console.ResetColor();
                    Text.GoodbyeText();
                    TestForKeys = false;
                    System.Threading.Thread.Sleep(5000);
                    Environment.Exit(0);
                }
                else if ((result.KeyChar == 'm') || (result.KeyChar == 'M'))
                {
                    Console.WriteLine("\nYou pressed: '" + result.KeyChar + "'. Going to Mammals.");
                    //Show a MallardDuck.
                    mallard.display();
                    mallard.performQuack();
                    mallard.performFly();
                    Console.WriteLine();
                    //Show a RubberDuck.
                    rubber.display();
                    rubber.performQuack();
                    rubber.performFly();
                    //Change the fly behaviour of the rubberduck.
                    rubber.setFlyBehaviour(new FlyRocketPowered());
                    rubber.performFly();
                    Console.WriteLine();
                }
                else if ((result.KeyChar == 'r') || (result.KeyChar == 'R'))
                {
                    Console.WriteLine("\nYou pressed: '" + result.KeyChar + "' Going to Reptiles.");

                    //Show Reptiles
                }
                else
                {
                    Console.Write("\nThis This is not a recognized command. Try again: ");
                }
            }
        }
    }
}
