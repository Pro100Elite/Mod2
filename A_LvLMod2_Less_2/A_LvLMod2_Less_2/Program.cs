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

            bool isMenu = true;

            var commands = new Dictionary<ConsoleKey, ICommand>
            {
                [ConsoleKey.D1] = new CreateCarCommand(factory),
                [ConsoleKey.D2] = new CreatDetailsCommand(factory),
            };

            while (isMenu)
            {
                Console.WriteLine("Press 1 - Create Car, 2 - Create Random Details, Escape - Exit");
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
