using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaverInTheTrash
{
    class Program
    {
        public static bool isMenu = true;

        static void Main(string[] args)
        {
            BeaverHouse House = new BeaverHouse();

            House.beaverKing.Name = "King!";
            House.beaverOne.Name = "Barbara";
            House.beaverTwo.Name = "Twix";

            var commands = new Dictionary<ConsoleKey, ICommand>()
            {
                [ConsoleKey.D1] = new ShowTrash(House),
                [ConsoleKey.D2] = new GiveBeaverTrash(House),
                [ConsoleKey.Escape] = new Exit()
            };

            while (isMenu)
            {
                Console.WriteLine("\nPress 1 - ShowTrashAndBeaver 2 - TakeTrash, Escape - Exit\n");
                var key = Console.ReadKey().Key;

                if (commands.ContainsKey(key))
                {
                    Console.Clear();
                    var selectCommand = commands[key];
                    selectCommand.Act();
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
