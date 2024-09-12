using Exersice02.Models;

namespace Exersice02.Services.Implementations
{
    public class VehicleService
    {
        public string CreateAndDriveCar(int initialFuel)
        {
            var car = new Car(initialFuel);
            car.Drive();
            return initialFuel > 0 ? "El coche está siendo manejado" : "El coche no tiene combustible";
        }

        public string RefuelAndDriveCar(int fuelAmount)
        {
            var car = new Car(0); 
            car.Refuel(fuelAmount);
            car.Drive();
            return "El coche está siendo manejado";
        }
    }
}
