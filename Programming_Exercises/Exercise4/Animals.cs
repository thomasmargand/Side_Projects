using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Animals
    {
        public string name;
        public int feet;
        public string sex;
        public string food;
        public string noise;
        public string species;

        public Animals()
        {
            name = "Null";
            feet = 2;
            sex = "He";
            food = "None";
            noise = "Loud";
            species = "human";
        }

        public void AssignName(string newName)
        {
            name = newName;
        }

        public void Feet(int newFeet)
        {
            feet = newFeet;
        }

        public void assignGender(string pronoun)
        {
            sex = pronoun;
        }

        public void Eats(string newFood)
        {
            food = newFood;
        }

        public void makeNoise(string newNoise)
        {
            noise = newNoise;
        }

        public void setSpecies(string newSpecies)
        {
            species = newSpecies;
        }
        
        public void Talk()
        {
            Console.WriteLine("This is a {0} named: {1}", species, name);
            Console.WriteLine("{0} eats: {1}", sex, food);
            Console.WriteLine("{0} has {1} feet", sex, feet);
            Console.WriteLine("{0} says: {1}", sex, noise);
        }
    }
}
