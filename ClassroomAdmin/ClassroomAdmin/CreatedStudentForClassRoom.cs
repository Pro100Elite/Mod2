using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAdmin
{
    class CreatedStudentForClassRoom: Command
    {
        protected List<ClassRoom> classRooms;
        protected Person student;

        public CreatedStudentForClassRoom(List<ClassRoom> classRooms)
        {
            this.classRooms = classRooms;
            student = new Student();
        }

        protected override void InternalLogic()
        {
            Console.Write("Input Name Student = ");
            Name = Console.ReadLine();
            Console.Write("Select Room: ");
            student.InToTheRoom(classRooms);
        }
    }
}
