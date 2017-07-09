using RefactorExample.Vehicles.Interfaces;

namespace RefactorExample.Vehicles
{
    public class Bicycle : IVehicle
    {
        private const int _maxSpeed = 40;
        public int MaximumSpeed => _maxSpeed;
    }
}