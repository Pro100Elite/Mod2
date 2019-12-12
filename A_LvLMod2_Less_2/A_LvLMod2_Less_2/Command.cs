using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class Command: ICommand
    {
        public virtual string Name { get; set; }

        public void Act()
        {
            InternalLogic();
        }

        protected virtual void InternalLogic()
        {
            Console.WriteLine("Base Command");
        }
    }
}
