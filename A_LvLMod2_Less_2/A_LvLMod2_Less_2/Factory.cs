using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class Factory
    {
        public readonly List<Car> cars = new List<Car>();


        public void CreateCar( ref int countWheel, ref int countEngine, ref int countSteeringWheel, ref int countSeat)
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
    }
}
