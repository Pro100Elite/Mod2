using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaverInTheTrash
{
    class GiveBeaverTrash: Command
    {
        protected BeaverHouse house;

        public GiveBeaverTrash(BeaverHouse house)
        {
            this.house = house;
        }

        protected override void InternalLogic()
        {
            var commandsBeaver = new Dictionary<ConsoleKey, Beaver>()
            {
                [ConsoleKey.D1] = house.beaverKing,
                [ConsoleKey.D2] = house.beaverOne,
                [ConsoleKey.D3] = house.beaverTwo
            };

            var commansTrash = new Dictionary<ConsoleKey, object>()
            {
                [ConsoleKey.D1] = "Pen",
                [ConsoleKey.D2] = "Stick",
                [ConsoleKey.D3] = "Ball",
                [ConsoleKey.D4] = "HydrogenBomb",
                [ConsoleKey.D5] = "Sword"
            };

            Console.WriteLine("\nSelect Beaver 1 - BeaverKing 2 - BeaverOne, 3 - BeaverTwo \n");
            var key = Console.ReadKey().Key;

            Console.WriteLine($"\nSelect Trash 1 - Pen 2 - Stick, 3 - Ball, 4 - HydrogenBomb, 5 - Sword \n");
            var keyFirst = Console.ReadKey().Key;

            if (commandsBeaver.ContainsKey(key))
            {
                Console.Clear();
                var selectBeaver = commandsBeaver[key];
                var selectTrash = commansTrash[keyFirst];
                house.TakeTrash(selectTrash, selectBeaver);
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
