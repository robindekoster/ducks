using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            //Can fly.
            Console.WriteLine("I'm flying!");
        }
    }
}
