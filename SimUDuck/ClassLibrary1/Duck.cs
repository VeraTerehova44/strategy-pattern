using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public abstract class Duck : FlyBehavior, QuackBehavior
    {
        protected  QuackBehavior quackBehavior;
        protected FlyBehavior flyBehavior;
        public string swim()
        {
            return "Буль буль буль" + this.GetType();
        }
        public abstract string display();

        public string performQuack()
        {
            return quackBehavior.Quack
        }
        public string performFly()
        {
            return flyBehavior.Fly
        }
        public FlyBehavior SetFlyBehavior(FlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
            return flyBehavior;
        }

        public QuackBehavior SetQuackBehavior(QuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
            return quackBehavior;
        }
    }

}

