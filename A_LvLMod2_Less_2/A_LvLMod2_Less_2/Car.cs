using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    class Car
    {
        ProviderDetails provider;

        public List<Detail> wheels = new List<Detail>();
        public List<Detail> engines = new List<Detail>();
        public List<Detail> steeringWheel = new List<Detail>();
        public List<Detail> seates = new List<Detail>();

        public Car(ProviderDetails provider)
        {
            this.provider = provider;
        }

        Guid guid = Guid.NewGuid();
        public int price = 1000;

        public void CompleteWheel()
        {
            if (provider.wheels.Count >= 4)
            {
                wheels = provider.wheels.GetRange(0,4);
            }
        }

        public void CompleteEngin()
        {
            if (provider.engines.Count >= 2)
            {
                engines = provider.engines.GetRange(0, 2);
            }
        }

        public void CompleteSteeringWheel()
        {
            if (provider.steeringWheel.Count >= 1)
            {
                steeringWheel = provider.steeringWheel.GetRange(0, 1);
            }
        }

        public void CompleteSeates()
        {
            if (provider.seates.Count >= 2)
            {
                seates = provider.seates.GetRange(0, 2);
            }
        }

        public override string ToString()
        {
            if (wheels.Count != 4 | engines.Count != 2 | steeringWheel.Count != 1 | seates.Count != 2)
            {
                return $@"not enough details: 
                kitWheel = {wheels.Count}/{4}, 
                kitEngine = {engines.Count}/{2}, 
                kitSteeringWheel = {steeringWheel.Count}/{1}, 
                kitSeat = {seates.Count}/{2}";
            }
            else
            {
                return $"CarSerialNumber = {guid}";
            }
        }
    }
}
