using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class ShowCompleteCars: Command
    {
        protected Factory factory;

        public ShowCompleteCars(Factory factory)
        {
            this.factory = factory;
        }

        protected override void InternalLogic()
        {
            Console.Clear();
            if (factory.cars.Count > 0)
            {
                foreach (var cars in factory.cars)
                {
                    Console.WriteLine(cars);
                }
            }
            else
            {
                Console.WriteLine("Not created");
            }
        }
    }
}
