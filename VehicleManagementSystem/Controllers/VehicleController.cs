using System.Collections.Generic;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Services;

/*
 * 
 * Controller to add a new car and get all cars in the
 * current instance.
 * 
 */

namespace VehicleManagementSystem.Controllers
{
    public class VehicleController : Controller
    {

        [HttpGet]
        [Route("api/vehicle/get-all-cars")]
        public IEnumerable<Vehicle> Get()
        {
            return VehicleServices.GetAllCars();
        }

        [HttpPost]
        [Route("api/vehicle/add-car")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody]JsonElement vehicle)
        {
            //Deserialize JSON object and extract car details
            string vehicleType = vehicle.GetProperty("type").ToString();
            string vehicleMake = vehicle.GetProperty("make").ToString();
            string vehicleModel = vehicle.GetProperty("model").ToString();
            string engine = vehicle.GetProperty("engine").ToString();
            int numOfDoors = int.Parse(vehicle.GetProperty("numOfDoors").ToString());
            int numOfWheels = int.Parse(vehicle.GetProperty("numOfWheels").ToString());
            string bodyType = vehicle.GetProperty("bodyType").ToString();


            try
            {
                //get the add car service to validate and store the data
                VehicleServices.AddCar(vehicleType,
                                       vehicleMake,
                                       vehicleModel,
                                       engine,
                                       numOfDoors,
                                       numOfWheels,
                                       bodyType);
            }
            catch
            {
                return BadRequest("Invalid input");
            }

            return Ok();
        }


    }
}
