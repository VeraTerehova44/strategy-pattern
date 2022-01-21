using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public abstract class Duck
    {
        public string quack()
        {
            return "Кряк " + this.GetType();
        }
        public string swim()
        {
            return "Бульк " + this.GetType();
        }
        public abstract string display();
    }

}
