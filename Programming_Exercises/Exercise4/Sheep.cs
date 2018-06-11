using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Sheep : Animals
    {
        public Sheep()
        {
            name = "LambChop";
            feet = 4;
            sex = "She";
            food = "hay";
            noise = "Baa!";
            species = "Sheep";
        }
    }
}
