using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class QuackNoWay : QuackBehavior
    {
        public void quack()
        {
            //This animal can't quack.
            Console.WriteLine("<<Silence>>");
        }
    }
}
