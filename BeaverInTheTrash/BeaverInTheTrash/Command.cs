﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaverInTheTrash
{
    class Command: ICommand
    {
        public virtual string Name { get; set; }

        public void Act()
        {
            InternalLogic();
        }

        protected virtual void InternalLogic()
        {
            Console.WriteLine("Tipo Commanda");
        }
    }
}
