using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAdmin
{
    class Student : Person
    {
        public Student(string name) : base(name)
        {
        }

        public override void InToTheRoom(List<ClassRoom> rooms)
        {
            base.InToTheRoom(rooms);
        }
    }
}
