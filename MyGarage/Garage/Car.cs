using MyGarage.Garage.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Garage
{
    abstract class Car : Vehicle
    {
        //properties
        public bool _RearCamera { get; }

        //methods
        public override void refueling()
        {
            if (FuelCapacity == Fuel.empty)
            {
                Console.WriteLine("Your forgot the fill up the tank you are now stranded on the interstate!!!");
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

        public void Drive()
        {
            if(_RearCamera)
            {
                Console.WriteLine($"I love to drive my {Color.gold} {GetType().Name} backwards down the driveway with my rearview camera.");
            }
            else
            {
                Console.WriteLine($"I love to drive my {GetType().Name}");
            }
            
        }

        

        
    }
}
