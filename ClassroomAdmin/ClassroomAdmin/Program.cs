using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAdmin
{
    class Program
    {

        private static List<ClassRoom> classRooms = new List<ClassRoom>();
        public static bool isMenu = true;

        static void Main(string[] args)
        {
            Admin admin = new Admin();

            var commands = new Dictionary<ConsoleKey, ICommand>()
            {
                [ConsoleKey.D1] = new AskAdmincs(classRooms, admin),
                [ConsoleKey.D2] = new CreatedStudentForClassRoom(classRooms),
                [ConsoleKey.D3] = new CreatedTeacherForClassRoom(classRooms),
                [ConsoleKey.D4] = new StatusRooms(classRooms),
                [ConsoleKey.Escape] = new Exit()
            };

            CreatedFourRooms(commands);

            while (isMenu)
            {
                Console.WriteLine("\nPress 1 - AskAdmin 2 - Created Student, 3 - Created Teacher , 4 - Status Rooms, Escape - Exit\n");
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

        public static void CreatedFourRooms(Dictionary<ConsoleKey, ICommand> command1)
        {
            ClassRoom room1 = new ClassRoom();
            classRooms.Add(room1);
            ClassRoom room2 = new ClassRoom();
            classRooms.Add(room2);
            ClassRoom room3 = new ClassRoom();
            classRooms.Add(room3);
            ClassRoom room4 = new ClassRoom();
            classRooms.Add(room4);
            var selectCommand = command1[ConsoleKey.D1];
            selectCommand.Act();
        }
    }
}
