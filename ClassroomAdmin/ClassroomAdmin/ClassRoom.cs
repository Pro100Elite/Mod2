using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAdmin
{
    class ClassRoom
    {
        public int Roominess { get; private set; }
        public bool IsTeacher = false;

        public List<Person> people = new List<Person>();

        public void RoominessValue(Admin admin)
        {
            while(Roominess <= 0)
            {
                Roominess = admin.Set();
            }
        }

        public void GetTeacher()
        {
            IsTeacher = true;
        }
    }
}
