using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAdmin
{
    class AskAdmincs: Command
    {
        protected List<ClassRoom> classRooms;
        protected Admin admin;

        public AskAdmincs(List<ClassRoom> classRooms, Admin admin)
        {
            this.classRooms = classRooms;
            this.admin = admin;
        }

        protected override void InternalLogic()
        {
            for (int i = 0; i < classRooms.Count(); i++)
            {
                if (classRooms[i].Roominess <= 0)
                {
                    Console.WriteLine($"room № {i + 1}");
                    classRooms[i].RoominessValue(admin);
                }
                else
                {
                    Console.WriteLine($"room № {i + 1}, RominessValue = {classRooms[i].Roominess}");
                }
            }
        }
    }
}
