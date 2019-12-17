using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class ProviderDetails
    {
        private Random random = new Random();
        public Detail detail { get; set; }
        public  List<Detail> wheels = new List<Detail>();
        public  List<Detail> engines = new List<Detail>();
        public  List<Detail> steeringWheel = new List<Detail>();
        public  List<Detail> seates = new List<Detail>();
        //public static List<Detail> details = new List<Detail>();

        public int allDetail = 4;

        public void RandomDetail()
        {
            Console.Clear();

            switch (random.Next(0, allDetail))
            {
                case 0:
                    detail = new Wheel(5);
                    wheels.Add(detail);
                    break;
                case 1:
                    detail = new Engine(100);
                    engines.Add(detail);
                    break;
                case 2:
                    detail = new SteeringWheel(10);
                    steeringWheel.Add(detail);
                    break;
                case 3:
                    detail = new Seat(20);
                    seates.Add(detail);
                    break;
            }
            Console.WriteLine("Created  Random Details");
        }
    }
}
