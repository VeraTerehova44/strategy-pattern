using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        public override string display()
        {
            return "Кряква " + this.GetType();
        }
    }
}
