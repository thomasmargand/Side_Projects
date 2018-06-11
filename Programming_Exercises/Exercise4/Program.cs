using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {

            //build a farm
            Cow betsy = new Cow();
            Chicken little = new Chicken();
            Goat billy = new Goat();
            Sheep lambchop = new Sheep();

            Console.WriteLine("Hello and welcome to my farm!");
            Console.WriteLine("Let me introduce you to our animals");
            Console.WriteLine();

            //Call the animals
            lambchop.Talk();
            little.Talk();
            billy.Talk();
            betsy.Talk();
            //our custom animal
            newAnimal();
        }

        //use the animal class to make a custom animal
        static void newAnimal()
        {
            Animals custom = new Animals();
            custom.AssignName("Barbatos");
            custom.makeNoise("Woof Woof");
            custom.Eats("the blood of his enemies.");
            custom.Feet(4);
            custom.setSpecies("Dog");

            custom.Talk();
        }
    }
}

