using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quckBehavior = new MuteQuack();
        }
        public override string display()
        {
            return "Деревянная утка " + flyBehavior.Fly() + quackBehavior.Quack() + this.GetType();
        }
    }
}