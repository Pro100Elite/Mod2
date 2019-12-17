using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class Factory
    {

        public List<Car> cars = new List<Car>();

        int kitWheel = 4;
        int kitEngine = 2;
        int kitSteeringWheel = 1;
        int kitSeat = 2;

        public int moneyReceived;
        public int moneyExpected;


        public void Prices()
        {
            moneyExpected = 0;
            moneyReceived = 0;
            foreach (var cr in cars)
            {
                if (cr.wheels.Count != 4 | cr.engines.Count != 2 | cr.steeringWheel.Count != 1 | cr.seates.Count != 2)
                {
                    moneyExpected += cr.price;
                }
                else
                {
                    moneyReceived += cr.price;
                }
            }
        }

        public void CreateCar(ProviderDetails provider)
        {
            Console.Clear();

            if (cars != null)
            {
                foreach(var cr in cars)
                {
                    if (cr.wheels.Count != kitWheel & provider.wheels.Count >= kitWheel)
                    {
                        cr.CompleteWheel();
                        provider.wheels.RemoveRange(0, kitWheel);
                        Console.WriteLine($"Complete! {cr.ToString()}");
                    } 
                    if (cr.engines.Count != kitEngine & provider.engines.Count >= kitEngine)
                    {
                        cr.CompleteEngin();
                        provider.engines.RemoveRange(0, kitEngine);
                        Console.WriteLine($"Complete! {cr.ToString()}");
                    }
                    if (cr.steeringWheel.Count != kitSteeringWheel & provider.steeringWheel.Count >= kitSteeringWheel)
                    {
                        cr.CompleteSteeringWheel();
                        provider.steeringWheel.RemoveRange(0, kitSteeringWheel);
                        Console.WriteLine($"Complete! {cr.ToString()}");
                    }
                    if (cr.seates.Count != kitSeat & provider.seates.Count >= kitSeat)
                    {
                        cr.CompleteSeates();
                        provider.seates.RemoveRange(0, kitSeat);
                        Console.WriteLine($"Complete! {cr.ToString()}");
                    }
                }
            }
                if (provider.wheels.Count >= kitWheel)
                {
                    Car car = new Car(provider);
                    car.CompleteWheel();
                    provider.wheels.RemoveRange(0, kitWheel);
                    cars.Add(car);
                    Console.WriteLine($"Created! {car.ToString()}");
                }
                else if (provider.engines.Count >= kitEngine)
                {
                    Car car = new Car(provider);
                    car.CompleteEngin();
                    provider.engines.RemoveRange(0, kitEngine);
                    cars.Add(car);
                    Console.WriteLine($"Created! {car.ToString()}");
                }
                else if (provider.steeringWheel.Count >= kitSteeringWheel)
                {
                    Car car = new Car(provider);
                    car.CompleteSteeringWheel();
                    provider.steeringWheel.RemoveRange(0, kitSteeringWheel);
                    cars.Add(car);
                    Console.WriteLine($"Created! {car.ToString()}");
                }
                else if (provider.seates.Count >= kitSeat)
                {
                    Car car = new Car(provider);
                    car.CompleteSeates();
                    provider.seates.RemoveRange(0, kitSeat);
                    cars.Add(car);
                    Console.WriteLine($"Created! {car.ToString()}");
                }
                else
                {
                    Console.WriteLine($@"not enough details:
                kitWheel = { provider.wheels.Count}/{ 4}, 
                kitEngine = { provider.engines.Count}/{ 2}, 
                kitSteeringWheel = { provider.steeringWheel.Count}/{ 1}, 
                kitSeat = { provider.seates.Count}/{ 2}
                ");
                }
        }
    }
}
