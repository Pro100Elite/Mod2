using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaverInTheTrash
{
    class ShowTrash: Command
    {

        protected BeaverHouse house;

        public ShowTrash(BeaverHouse house)
        {
            this.house = house;
        }

        protected override void InternalLogic()
        {
            house.Show();
        }
    }
}
