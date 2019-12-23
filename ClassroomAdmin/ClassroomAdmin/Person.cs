using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAdmin
{
    abstract class Person
    {
        protected ClassRoom selectRoom;

        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }

        public virtual void InToTheRoom(List<ClassRoom> rooms)
        {
            var commands = new Dictionary<ConsoleKey, ClassRoom>()
            {
                [ConsoleKey.D1] = rooms[0],
                [ConsoleKey.D2] = rooms[1],
                [ConsoleKey.D3] = rooms[2],
                [ConsoleKey.D4] = rooms[3],
            };

            Console.WriteLine("\nPress 1 - Room1 2 - Room2, 3 - Room3, 4 - Room4\n");
            var key = Console.ReadKey().Key;

            if (commands.ContainsKey(key))
            {
                Console.Clear();
                selectRoom = commands[key];
                if (selectRoom.people.Count() < selectRoom.Roominess)
                {
                    selectRoom.people.Add(this);
                }
                else
                {
                    Console.WriteLine("there are no places");
                }
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
