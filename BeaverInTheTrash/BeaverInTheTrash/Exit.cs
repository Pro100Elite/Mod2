﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaverInTheTrash
{
    class Exit: Command
    {
        protected override void InternalLogic()
        {
           Program.isMenu = false;
        }
    }
}
