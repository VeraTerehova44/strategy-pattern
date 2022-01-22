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
            Duck duck2 = new ReadheaddDuck();
            Duck duck3 = new RubberDuck();
            Duck duck4 = new DecoyDuck();
            Duck[] massDuck = new Duck[] { duck1, duck2, duck3, duck4 };
            foreach (Duck duck in massDuck)
            {
                Console.WriteLine(duck.swim());
                Console.WriteLine(duck.display());
                if (duck is Quackble)
                {
                    Console.WriteLine((duck as Quackble).quack());
                }
                if (duck is Flyable)
                {
                    Console.WriteLine((duck as Flyable).fly());
                }
            }
            Console.ReadLine();
        }
    }
}

