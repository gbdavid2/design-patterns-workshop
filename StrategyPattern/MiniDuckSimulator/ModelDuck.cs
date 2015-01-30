﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Quack
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
