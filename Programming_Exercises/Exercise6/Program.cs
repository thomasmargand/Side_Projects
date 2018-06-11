using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {

            //build a unit
            HR susan = new HR();
            Infantry bob = new Infantry();
            Medic jeff = new Medic();
            Cook ashley = new Cook();

            Console.WriteLine("Hello and welcome to the Army");
            Console.WriteLine("Let me introduce you to the unit");
            Console.WriteLine();

            //Call the animals
            susan.Talk();
            bob.Talk();
            jeff.Talk();
            ashley.Talk();
            //our custom animal
            newSoldier();
        }

        //use the animal class to make a custom animal
        static void newSoldier()
        {
            Soldier custom = new Soldier();
            custom.AssignName("Barbatos");
            custom.Job("Combat Ninja");
            custom.Tis(8);
            custom.assignGender("He");
            custom.Trait("you didn't see or hear him come in the room.");
            custom.Says("in the middle of chaos lies opportunity");

            custom.Talk();
        }
    }
}

