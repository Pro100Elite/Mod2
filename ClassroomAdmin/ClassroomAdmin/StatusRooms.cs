using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAdmin
{
    class StatusRooms:Command
    {
        protected List<ClassRoom> classRooms;

        public StatusRooms(List<ClassRoom> classRooms)
        {
            this.classRooms = classRooms;
        }

        protected override void InternalLogic()
        {
            for (int i = 0; i < classRooms.Count(); i++)
            {
                Console.WriteLine($"room № {i + 1}");
                foreach ( var pl in classRooms[i].people)
                {
                    Console.WriteLine(pl.Name);
                }
            }
        }
    }
}
