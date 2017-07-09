using System;
using System.Collections.Generic;
using RefactorExample.Vehicles;
using RefactorExample.Vehicles.Interfaces;

namespace RefactorExample
{
    class CleanProgram
    {
        static void CleanMain()
        {
            IList<IVehicle> vehicles = CreateListOfVehicles();
            foreach (var vehicle in vehicles)
            {
                PrintInformationAboutVehicleMaximumSpeed(vehicle);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static IList<IVehicle> CreateListOfVehicles()
        {
            return new List<IVehicle> {new Car(), new Bicycle(), new Motorcycle(), new Train()};
        }

        private static void PrintInformationAboutVehicleMaximumSpeed(IVehicle vehicle)
        {
            Console.WriteLine($"{vehicle.GetType().Name} can move at maximum speed of {vehicle.MaximumSpeed} km/h");
        }
    }
}