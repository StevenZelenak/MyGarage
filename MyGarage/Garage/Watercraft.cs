using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Garage
{
    class Watercraft : Vehicle
    {


        //methods
        public override void refueling()
        {
            if(FuelCapacity == Fuel.empty)
            {
                Console.WriteLine("Your forgot the fill up the tank you are now stranded in the lake!!!");
            }
            else if(FuelCapacity == Fuel.half)
            {
                Console.WriteLine("You have half a tank of gas right now. I wonder if we should fill up?");
            }
            else
            {
                Console.WriteLine("The gas tank is full baby!!!!");
            }
        }

        public void Drive()
        {
            Console.WriteLine($"I love to drive my {Color.red} {GetType().Name} across the lake");
        }


    }
}
