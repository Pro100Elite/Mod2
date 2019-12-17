using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_LvLMod2_Less_2
{
    abstract class Detail
    {
        public int Price { get; }

        public Detail(int price)
        {
            Price = price;

        }
    }
}
