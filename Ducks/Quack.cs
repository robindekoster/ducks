using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            //Duck quacking.
            Console.WriteLine("Quack.");
        }
    }
}
