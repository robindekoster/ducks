using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class Text
    {
        //This is the welcome text for the Zeeland Zoo.
        public static void WelcomeText()
        {
            System.Console.Clear();
            Console.WriteLine("Welcome in the Zeeland Zoo!");
            Console.WriteLine("We have mammals and reptiles.");
            Console.Write("We have a total of: ");
            Console.Write(Duck.AnimalCounter);
            Console.WriteLine(" Animals.");
            Console.WriteLine("Press M(ammals), R(eptiles) or Q(uit)");
        }

        //This is the goobye text for the Zeeland Zoo.
        public static void GoodbyeText()
        {
            Console.WriteLine("We were happy to have you here at the Zeeland Zoo!");
            Console.WriteLine("The annimals are certainly going to miss you.");
            Console.WriteLine("Goodbye...");
        }
    }
}
