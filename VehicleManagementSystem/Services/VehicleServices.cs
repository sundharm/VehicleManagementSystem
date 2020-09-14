using System;
using System.Collections.Generic;
using VehicleManagementSystem.Models;

/*
 *
 * Service class to separate the insertion/retrieval logic
 * of data (in memory now). This can later be modified to
 * work with a database.
 *
 */

namespace VehicleManagementSystem.Services
{
    public class VehicleServices : IVehicleService
    {
        private static List<Vehicle> vehicles = new List<Vehicle>();

        //Adds a new vehicle and stores in current instance's memory
        public bool AddNewVehicle(Vehicle vehicle)
        {
            try
            {
                int id = GetNewID();
                vehicle.VehicleId = id;
                vehicles.Add(vehicle);
                return true;
            }
            catch
            {
                throw;
            }
        }

        //returns new id as the last element in list plus 1 to maintain uniqueness
        //when deletion/removal takes place later
        public int GetNewID()
        {
            int id = 0;
            if (vehicles.Count > 0)
            {
                id = vehicles[vehicles.Count - 1].VehicleId + 1;
            }
            
            return id;
        }

        //returns the current instance's list of vehicles
        public List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> carList = new List<Vehicle>();
            foreach(Vehicle v in vehicles)
            {
                if (v.VehicleType.Equals(Constants.CAR))
                    carList.Add(v);
            }
            return carList;
        }

    }

}
