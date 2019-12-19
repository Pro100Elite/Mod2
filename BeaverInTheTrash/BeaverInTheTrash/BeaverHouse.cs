using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaverInTheTrash
{
    class BeaverHouse
    {
        Dictionary<object, Beaver> communicationBeavers = new Dictionary<object, Beaver>();

        public Beaver beaverKing = new Beaver();
        public Beaver beaverOne = new Beaver();
        public Beaver beaverTwo = new Beaver();

        public void Show()
        {
            foreach (var commun in communicationBeavers)
            {
                Console.WriteLine($"{commun.Key} Taked {commun.Value.Name}");
            }
        }

        public void TakeTrash(object trash, Beaver beaver)
        {
            try
            {
                communicationBeavers.Add(trash, beaver);
            }
            catch
            {
                Console.WriteLine("Taken by another beaver");
            }
        }
    }
}
