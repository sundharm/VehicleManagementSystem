using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleManagementSystem.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleManagementSystem.Controllers
{
    [Route("api/[controller]")]
    public class VehicleController : Controller
    {
        // GET: api/values
        [HttpGet]
        [Route("api/vehicle/get-all-vehicles")]
        public IEnumerable<Vehicle> Get()
        {
            List<Vehicle> list = new List<Vehicle>() ;
            return list;
        }

        
        // POST api/values
        [HttpPost]
        [Route("api/vehicle/add-vehicle")]
        public void Post([FromBody] Vehicle vehicle)
        {
            
        }


    }
}
