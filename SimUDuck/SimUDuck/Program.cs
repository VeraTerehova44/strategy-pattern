using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck1 = new MallardDuck();
            Duck duck2 = new RedHeadDuck();
            Duck duck3 = new RubberDuck();
            Duck duck4 = new DecoyDuck();
            Duck[] massDuck = new Duck[] { duck1, duck2, duck3, duck4 };
            foreach (Duck duck in massDuck)
            {
                Console.WriteLine(duck.Swim());
                Console.WriteLine(duck.Display());
                Console.WriteLine(duck.PerformFly());
                Console.WriteLine(duck.PerformQuack());

            }
            FlyBehavior flyBehavior = new FlyWithWings();
            QuackBehavior quackBehavior = new Squeak();
            duck4.SetFlyBehavior(flyBehavior);
            duck4.SetQuackBehavior(quackBehavior);
            Console.WriteLine(duck4.Display());
            Console.WriteLine(duck4.PerformFly());
            Console.WriteLine(duck4.PerformQuack());
            Console.ReadLine();
        }
    }
}

