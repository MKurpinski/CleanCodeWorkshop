using RefactorExample.Vehicles.Interfaces;

namespace RefactorExample.Vehicles
{
    public class Car : IVehicle
    {
        private const int _maxSpeed = 250;

        public int MaximumSpeed => _maxSpeed;
    }
}