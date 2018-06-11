using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Soldier
    {
        public string name;
        public int tis;
        public string sex;
        public string job;
        public string trait;
        public string says;

        public Soldier()
        {
            name = "Null";
            job = "None";
            tis = 2;
            sex = "He";
            trait = "Loud";
            says = "human";
        }

        public void AssignName(string newName)
        {
            name = newName;
        }

        public void Job(string newJob)
        {
            job = newJob;
        }

        public void Tis(int newTis)
        {
            tis = newTis;
        }

        public void assignGender(string pronoun)
        {
            sex = pronoun;
        }

        public void Trait(string newTrait)
        {
            trait = newTrait;
        }

        public void Says(string newSays)
        {
            says = newSays;
        }
        
        public void Talk()
        {
            Console.WriteLine("This is {0} {1} is a {2}", name, sex, job);
            Console.WriteLine("{0} has been in the Army for {1} years", sex, tis);
            Console.WriteLine("{0} {1}", sex, trait);
            Console.WriteLine("{0} says: {1}", sex, says);
        }
    }
}
