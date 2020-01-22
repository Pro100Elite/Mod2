using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSooooOn
{
    class Program
    {
        private static List<PropObj> propObjs;
        static void Main(string[] args)
        {
           propObjs = new List<PropObj>();
           Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                propObjs.Add(CreatedProp(rand.Next(0, 1000)));
            }

            foreach (var pr in propObjs)
            {
                var prConv = JsonConvert.SerializeObject(pr);
                Console.WriteLine(prConv);
                var prDeConv = JsonConvert.DeserializeObject<PropObj>(prConv);
                Console.WriteLine(prDeConv.NumberRand);
            }
            Console.ReadKey();

        }

        static PropObj CreatedProp(int rand)
        {
            var pr = new PropObj();
            pr.NumberRand = rand;
            return pr;
        }
    }
}
