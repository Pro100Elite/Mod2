using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class ShowStatusCars: Command
    {
        protected Factory factory;

        public ShowStatusCars(Factory factory)
        {
            this.factory = factory;
        }

        protected override void InternalLogic()
        {
            Console.Clear();
            factory.Prices();
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
            Console.WriteLine($"MoneyExpected ={factory.moneyExpected}$\nMoneyReceived = {factory.moneyReceived}$");
        }
    }
}
