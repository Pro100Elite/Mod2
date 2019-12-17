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
        protected ProviderDetails provider;

        public CreateCarCommand(Factory factory, ProviderDetails provider)
        {
            this.factory = factory;
            this.provider = provider;
        }

        protected override void InternalLogic()
        {
            factory.CreateCar(provider);
        }
    }
}
