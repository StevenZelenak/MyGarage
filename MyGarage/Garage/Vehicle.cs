using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Garage
{
    abstract class Vehicle
    {
        //properties
        public Fuel FuelCapacity { get; }
        public Color Color { get; }
        public int PassengerCount { get; set; }

        public abstract void refueling();
        
        public void breaking()
        {
            Console.WriteLine($"I hit the breaks in my {GetType().Name} and it slowly stopped moving!!!");
        }

        public void driving(int passengercount)
        {
            PassengerCount = passengercount;
            Console.WriteLine($"I am driving to my favorite store in my {Color.red} {PassengerCount} seat {GetType().Name}");
        }
    }
}
