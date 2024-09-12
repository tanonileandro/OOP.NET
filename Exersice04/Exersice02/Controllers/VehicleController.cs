using Exersice02.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Exersice02.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleService _vehicleService;

        public VehicleController(VehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpPost("create-and-drive")]
        public IActionResult CreateAndDriveCar([FromQuery] int initialFuel)
        {
            var result = _vehicleService.CreateAndDriveCar(initialFuel);
            return Ok(result);
        }

        [HttpPost("refuel-and-drive")]
        public IActionResult RefuelAndDriveCar([FromQuery] int fuelAmount)
        {
            var result = _vehicleService.RefuelAndDriveCar(fuelAmount);
            return Ok(result);
        }
    }
}
