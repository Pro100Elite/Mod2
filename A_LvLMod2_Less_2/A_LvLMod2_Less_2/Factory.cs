using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class Factory
    {
        private readonly List<Car> cars = new List<Car>();

        private Random random = new Random();

        private int countWheel;
        private int countEngine;
        private int countSteeringWheel;
        private int countSeat;
        private int allDetail = 4;

        public void CreateCar()
        {
            Console.Clear();
            int kitWheel = 4;
            int kitEngine = 2;
            int kitSteeringWheel = 1;
            int kitSeat = 2;

            if (countWheel >= kitWheel & countEngine >= kitEngine & countSteeringWheel >= kitSteeringWheel & countSeat >= kitSeat)
            {
                Car car = new Car();

                cars.Add(car);

                countWheel -= kitWheel;
                countEngine -= kitEngine;
                countSteeringWheel -= kitSteeringWheel;
                countSeat -= kitSeat;

                Console.WriteLine($"Created! {car.ToString()}");
            }
            else
            {
                Console.WriteLine($@"not enough details: 
kitWheel = {countWheel}/{kitWheel}, 
kitEngine = {countEngine}/{kitEngine}, 
kitSteeringWheel = {countSteeringWheel}/{kitSteeringWheel}, 
kitSeat = {countSeat}/{kitSeat}");
            }
        }

        public void RandomDetail()
        {
            Console.Clear();

            switch (random.Next(0, allDetail))
            {
                case 0:
                    Wheel wheel = new Wheel();
                    countWheel++;
                    break;
                case 1:
                    Engine engine = new Engine();
                    countEngine++;
                    break;
                case 2:
                    SteeringWheel steeringWheel = new SteeringWheel();
                    countSteeringWheel++;
                    break;
                case 3:
                    Seat seat = new Seat();
                    countSeat++;
                    break;
            }
            Console.WriteLine("Created  Random Details");
        }
    }
}
