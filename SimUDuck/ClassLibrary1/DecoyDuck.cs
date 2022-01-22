using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public class DecoyDuck : Duck
    {
        public override string display()
        {
            return "Деревянная утка " + this.GetType();
        }
    }
}