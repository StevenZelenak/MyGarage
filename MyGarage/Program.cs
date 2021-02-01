using MyGarage.Garage;
using MyGarage.Garage.Aircrafts;
using MyGarage.Garage.Cars;
using MyGarage.Garage.Watercrafts;
using System;
using System.Collections.Generic;

namespace MyGarage
{
    class Program
    {
        public static void Main()
        {
            //------------------------------------------------------------------------
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            PassengerPlane plane1 = new PassengerPlane();
            PrivateJet plane2 = new PrivateJet();
            Spaceship plane3 = new Spaceship();
            //creat a list of planes
            var planes = new List<Aircraft>();
            planes.Add(plane1);
            planes.Add(plane2);
            planes.Add(plane3);
            //loop over the list with a foreach and call method Fly() for each one
            foreach (var plane in planes)
            {
                plane.Fly();
            }
            //--------------------------------------------------------------------------


            //------------------------------------------------------------------------
            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            NissanLeaf car1 = new NissanLeaf();
            NissanKicks car2 = new NissanKicks();
            NissanRogue car3 = new NissanRogue();
            //creat a list of cars
            var cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            //loop over the list with a foreach and call method Drive() for each one
            foreach (var car in cars)
            {
                car.Drive();
            }
            //--------------------------------------------------------------------------

            //--------------------------------------------------------------------------
            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            MotorBoat boat1 = new MotorBoat();
            RowBoat boat2 = new RowBoat();
            Yacht boat3 = new Yacht();
            //creat a list of boat
            var boats = new List<Watercraft>();
            boats.Add(boat1);
            boats.Add(boat2);
            boats.Add(boat3);
            //loop over the list with a foreach and call method Drive() for each one
            foreach (var boat in boats)
            {
                boat.Drive();
            }
            //--------------------------------------------------------------------------
        }
    }
}
