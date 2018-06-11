using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Chicken : Animals
    {
        public Chicken()
        {
            name = "Chicken Little";
            feet = 2;
            sex = "He";
            food = "feed";
            noise = "Cluck Cluck!";
            species = "Chicken";
        }
    }
}
