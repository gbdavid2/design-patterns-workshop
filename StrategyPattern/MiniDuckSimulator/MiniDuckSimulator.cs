using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Quack
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.display();
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.display();
            model.performFly();
            model.FlyBehaviour = new FlyRocketPowered();
            model.performFly();
            Console.ReadKey();
        }
    }
}
