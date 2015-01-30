using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Quack
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            QuackBehaviour = new Quack();
            FlyBehaviour = new FlyWithWings();
        }

        public override void display()
        {
          Console.WriteLine("I'm a real Mallard Duck!");
        }
    }
}
