using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            //Can not fly
            Console.WriteLine("I am flying with a rocket.");
        }
    }
}
