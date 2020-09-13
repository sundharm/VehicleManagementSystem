using System.Collections.Generic;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleManagementSystem.Controllers
{
    public class VehicleController : Controller
    {

        [HttpGet]
        [Route("api/vehicle/get-all-vehicles")]
        public IEnumerable<Vehicle> Get()
        {
            return VehicleService.GetAllVehicles();
        }

        [HttpPost]
        [Route("api/vehicle/add-vehicle")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody]JsonElement vehicle)
        {
            try
            {
                VehicleService.ExtractVehicleDetails(vehicle);
            }
            catch
            {
                return BadRequest();
            }

            return Ok();
        }


    }
}
