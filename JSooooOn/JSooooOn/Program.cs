using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using MyJsonLib;

namespace JSooooOn
{
    class Program
    {
        private static List<PropObj> propObjs;
        static void Main(string[] args)
        {
           propObjs = new List<PropObj>();
           Random rand = new Random();
            MyAtribut atr = new MyAtribut();

            for (int i = 0; i < 10; i++)
            {
                propObjs.Add(CreatedProp(rand.Next(0, 1000)));
            }

            foreach (var pr in propObjs)
            {
                //var prConv = JsonConvert.SerializeObject(pr);
                //Console.WriteLine(prConv);
                var prConv1 = ConverterToJson.SerializeObj(pr,atr);
                Console.WriteLine(prConv1);
                Console.WriteLine("============");
                var prDeConv = JsonConvert.DeserializeObject<PropObj>(prConv1);
                Console.WriteLine(prDeConv.NumberRand);
                Console.WriteLine("============");
            }
            Console.ReadKey();
        }

        static PropObj CreatedProp(int rand)
        {
            var pr = new PropObj();
            pr.NumberRand = rand;
            pr.Number = 2;
            pr.NumberRandstr = "fsdfs";
            return pr;
        }
    }
}
