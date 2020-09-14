using System;
using System.Collections.Generic;
using VehicleManagementSystem.Models;

/*
 * 
 * Interface to define the functions of service class
 * 
 */

namespace VehicleManagementSystem.Services
{
    public interface IVehicleService
    {
        bool AddNewVehicle(Vehicle vehicle);
        int GetNewID();
        List<Vehicle> GetAllVehicles();
    }
}
