using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            ProviderDetails provider = new ProviderDetails();

            bool isMenu = true;

            var commands = new Dictionary<ConsoleKey, ICommand>
            {
                [ConsoleKey.D1] = new CreateCarCommand(factory, provider),
                [ConsoleKey.D2] = new CreatDetailsCommand(provider),
                [ConsoleKey.D3] = new ShowStatusCars(factory)
            };

            while (isMenu)
            {
                Console.WriteLine("Press 1 - Create Car, 2 - Create Random Details, 3 - Show All Status Cars, Escape - Exit");
                var key = Console.ReadKey().Key;

                if (!commands.ContainsKey(key))
                {
                    break;
                }

                var selectCommand = commands[key];
                selectCommand.Act();
            }
        }
    }
}
