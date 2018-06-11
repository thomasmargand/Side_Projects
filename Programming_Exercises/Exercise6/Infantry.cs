using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Infantry : Soldier
    {
        public Infantry()
        {
            name = "Bob";
            tis = 1;
            sex = "He";
            job = "Infantryman";
            trait = "says POG a lot.";
            says = "there's the infantry and then everybody else";
        }
    }
}
