using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public abstract class Duck
    {
        public static int AnimalCounter = 0;
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public Duck()
        {
            AnimalCounter++;
        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void setFlyBehaviour(FlyBehavior fb)
        {
            Console.WriteLine("I've evolved!");
            flyBehavior = fb;
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void setQuackBehaviour(QuackBehavior qb)
        {
            Console.WriteLine("I've eveolved!");
            quackBehavior = qb;
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
