using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Garage
{
    class Aircraft : Vehicle
    {
        

        //methods
        public override void refueling()
        {
            if (FuelCapacity == Fuel.empty)
            {
                Console.WriteLine("Your forgot the fill up the tank and I am now falling out of the sky!!!");
            }
            else if (FuelCapacity == Fuel.half)
            {
                Console.WriteLine("You have half a tank of gas right now. I wonder if we should fill up?");
            }
            else
            {
                Console.WriteLine("The gas tank is full baby!!!!");
            }
        }

        public void Fly()
        {
            Console.WriteLine($"I love to fly my {Color.gold} {GetType().Name}");
        }



    }
}
