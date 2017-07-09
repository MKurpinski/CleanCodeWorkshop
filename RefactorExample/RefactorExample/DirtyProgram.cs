using System;
using System.Collections;
using System.Collections.Generic;

namespace RefactorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Vehicle> vehicles = new List<Vehicle>{new Vehicle("Car"), new Vehicle("Train"), new Vehicle("Bicycle"), new Vehicle("Motorcycle"), new Vehicle("Computer") };
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Name == "Car")
                    Console.WriteLine($"{vehicle.Name} can move at maximum speed of 250 km/h");
                else if (vehicle.Name == "Train")
                    Console.WriteLine($"{vehicle.Name} can move at maximum speed of 175 km/h");
                else if (vehicle.Name == "Bicycle")
                    Console.WriteLine($"{vehicle.Name} can move at maximum speed of 40 km/h");
                else if(vehicle.Name == "Motorcycle")
                    Console.WriteLine($"{vehicle.Name} can move at maximum speed of 320 km/h");
                else
                    Console.WriteLine($"{vehicle.Name} cannot be recognized as valid Vehicle");
            }
        }

        private class Vehicle
        {
            public string Name { get; private set; }

            public Vehicle(string name)
            {
                Name = name;
            }
        }
    }
}