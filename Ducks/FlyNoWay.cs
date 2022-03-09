using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            //Can not fly
            Console.WriteLine("I can't fly.");
        }
    }
}
