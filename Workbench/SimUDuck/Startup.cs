﻿using System;
using System.Globalization;
using System.Linq;

namespace SimUDuck
{
    class Startup
    {
        static void Main(string[] args)
        {
            IDuck[] ducks = new IDuck[]
            {
                new MallardDuck(new FlyWithWings(), new Quack()),
                new RedheadDuck(new FlyWithWings(), new Quack()),
                new RubberDuck(new FlyNoWay(), new Squeak()),
                new DecoyDuck(new FlyNoWay(), new MuteQuack())
                /* Insert Iron and Papper ducks also. It will be fun */
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
                duck.Swim();
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}

