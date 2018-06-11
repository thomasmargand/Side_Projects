using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Medic : Soldier
    {
        public Medic()
        {
            name = "Jeff";
            tis = 4;
            sex = "He";
            job = "Combat Medic";
            trait = "is probably the saltiest looking person you have ever seen";
            says = "go do your MedPros!";
        }
    }
}
