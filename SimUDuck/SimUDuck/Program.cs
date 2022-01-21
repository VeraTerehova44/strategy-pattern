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
            Duck[] strDuck = new Duck[] { duck1, duck2 };
            for (int i = 0; i < strDuck.Length; i++)
            {
                Console.WriteLine($"{strDuck[i].quack()}\n" + $"{strDuck[i].swim()}\n" + $"{strDuck[i].display()}");

            }
            //Console.WriteLine(duck1.display());
            //Console.WriteLine(duck1.quack());
            //Console.WriteLine(duck1.swim());
            //Console.WriteLine(duck2.display());
            //Console.WriteLine(duck2.quack());
            //Console.WriteLine(duck2.swim());
            Console.ReadLine();
        }
    }
}
