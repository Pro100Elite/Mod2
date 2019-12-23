using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAdmin
{
    class CreatedTeacherForClassRoom: Command
    {
        protected List<ClassRoom> classRooms;
        protected Person teacher;

        public CreatedTeacherForClassRoom(List<ClassRoom> classRooms)
        {
            this.classRooms = classRooms;
            teacher = new Teacher();
        }

        protected override void InternalLogic()
        {
            Console.Write("Input Name Teacher = ");
            Name = Console.ReadLine();
            Console.Write("Select Room: ");
            teacher.InToTheRoom(classRooms);
        }
    }
}
