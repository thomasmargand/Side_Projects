using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Question: Write a program that finds the smallest angle between the hour hand 
             * and the minute hand of a clock for a user input time.  All inputs will be valid 
             * and input will be an integer in 24hr time format.*/

            int userTime = int.Parse(Console.ReadLine());
            
            Console.WriteLine(findAngle(userTime)); 
            
            int findAngle(int time)
            {
                int hr = 30;
                int min = 6;
                
                if (time > 1200)
                {
                    time = time - 1200;
                }

                int hrAngle = (time / 100) * hr;
                int minAngle = (time % 100) * min;
                int angle = Math.Abs(hrAngle - minAngle);

                if (angle > 180)
                {
                    angle = 360 - angle;
                }

                return angle;
                
            }
        }
    }
}
