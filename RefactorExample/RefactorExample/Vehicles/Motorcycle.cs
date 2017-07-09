using RefactorExample.Vehicles.Interfaces;

namespace RefactorExample.Vehicles
{
    public class Motorcycle : IVehicle
    {
        private const int _maxSpeed = 320;
        public int MaximumSpeed => _maxSpeed;
    }
}