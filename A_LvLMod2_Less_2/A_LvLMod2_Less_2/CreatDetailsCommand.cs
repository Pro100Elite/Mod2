using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class CreatDetailsCommand: Command
    {
        protected ProviderDetails provider;

        public CreatDetailsCommand(ProviderDetails provider)
        {
            this.provider = provider;
        }

        protected override void InternalLogic()
        {
            provider.RandomDetail();
        }
    }
}
