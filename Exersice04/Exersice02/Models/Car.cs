using Exersice02.Services.Interface;

namespace Exersice02.Models
{
    public class Car : IVehicle
    {
        private int _fuel;

        public Car(int initialFuel)
        {
            _fuel = initialFuel;
        }

        public void Drive()
        {
            if (_fuel > 0)
            {
                Console.WriteLine("El coche está siendo manejado");
            }
            else
            {
                Console.WriteLine("El coche no tiene combustible");
            }
        }

        public bool Refuel(int amount)
        {
            _fuel += amount;
            return true;
        }
    }
}
