using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quckBehavior = new Squeak();
        }
        public override string display()
        {
            return "Резиновая утка " + this.GetType();
        }
        public string quack()
        {
            return "Пи-пи " + this.GetType();
        }
    }
}