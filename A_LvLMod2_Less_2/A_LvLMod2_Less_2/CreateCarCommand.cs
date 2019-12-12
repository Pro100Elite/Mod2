using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class CreateCarCommand: Command
    {

        protected Factory factory;

        public CreateCarCommand(Factory factory)
        {
            this.factory = factory;
        }

        protected override void InternalLogic()
        {
            factory.CreateCar();
        }
    }
}
