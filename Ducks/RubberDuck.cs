using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new QuackNoWay();
            flyBehavior = new FlyNoWay();
        }

        public override void display()
        {
            Console.WriteLine("I'm a rubber duck.");
        }
    }
}
