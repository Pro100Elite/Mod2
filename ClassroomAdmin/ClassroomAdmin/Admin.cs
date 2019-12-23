using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAdmin
{
    class Admin
    {
        public int CountRoominess { get; private set; }

        public int Set()
        {
            Console.WriteLine("Set Roominess");
            if (!int.TryParse(Console.ReadLine(), out int Count))
            {
                Console.WriteLine("Error Format");
            }
            CountRoominess = Count;
            return Count;
        }
    }
}
