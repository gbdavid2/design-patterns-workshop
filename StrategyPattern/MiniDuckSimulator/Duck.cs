using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Quack
{
    public abstract class Duck
    {
        public FlyBehaviour FlyBehaviour { get; set; }
        public QuackBehaviour QuackBehaviour { get; set; }

        public Duck() { }

        public abstract void display();

        public void performFly()
        {
            FlyBehaviour.fly();
        }

        public void performQuack()
        {
            QuackBehaviour.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

    }
}
