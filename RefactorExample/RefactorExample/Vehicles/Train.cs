using RefactorExample.Vehicles.Interfaces;

namespace RefactorExample.Vehicles
{
    public class Train : IVehicle
    {
        private const int _maxSpeed = 175;
        public int MaximumSpeed => _maxSpeed;
    }
}