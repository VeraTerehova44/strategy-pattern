using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public abstract class Duck : FlyBehavior, QuackBehavior
    {
        public QuackBehavior quackBehavior { get; set; }
        protected FlyBehavior flyBehavior { get; set; }

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
    }

}

