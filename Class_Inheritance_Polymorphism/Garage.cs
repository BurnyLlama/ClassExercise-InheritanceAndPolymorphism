using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance_Polymorphism
{
    internal class Garage
    {
        public Vehicle[] ParkedVehicles;
        public Garage(int parkingSpaces)
        {
            ParkedVehicles = new Vehicle[parkingSpaces];
        }

        public void ParkVehicle(Vehicle vehicleToPark)
        {
            int emptyGarageSpot = Array.FindIndex(ParkedVehicles, vehicle => vehicle == null);
            
            // Check if there is no empty garage spot.
            if (emptyGarageSpot == -1)
            {
                Console.WriteLine("Sorry, the garage is full!");
                return;
            }

            // Check if the vehicle is already parked in the garage.
            if (ParkedVehicles.Where(vehicle => vehicle != null).Any(vehicle => vehicle.ID == vehicleToPark.ID))
            {
                Console.WriteLine("Sorry, this vehicle is already parked in the garage!");
                return;
            }

            // Check if it is parked elsewhere!
            if (vehicleToPark.IsParked)
            {
                Console.WriteLine("Sorry, this vehicle is already parked elsewhere!");
                return;
            }

            ParkedVehicles[emptyGarageSpot] = vehicleToPark;
            vehicleToPark.IsParked = true;
        }

        public void ListParkedVehicles()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("These are the vehicles in the garage:");
            Console.WriteLine("-------------------------------------");
            foreach (Vehicle vehicle in ParkedVehicles)
            {
                if (vehicle == null)
                {
                    Console.WriteLine("This is an empty parking spot!");
                    continue;
                }

                Console.WriteLine(vehicle.Model);
            }
            Console.WriteLine("-------------------------------------\n");
        }

        public void GetVehicle(int spotNumber)
        {
            // Check if that spot is empty.
            if (ParkedVehicles[spotNumber] == null)
            {
                Console.WriteLine("Sorry, but there is no vehicle at that spot.");
                return;
            }

            ParkedVehicles[spotNumber].IsParked = false;
            ParkedVehicles[spotNumber] = null;
        }
    }
}
