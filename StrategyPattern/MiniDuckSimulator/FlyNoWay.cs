using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Quack
{
    class FlyNoWay: FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
