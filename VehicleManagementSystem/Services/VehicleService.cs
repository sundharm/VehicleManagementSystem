using System;
using System.Collections.Generic;
using System.Text.Json;
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
    public class VehicleService
    {
        private static List<Vehicle> vehicles = new List<Vehicle>();

        //Adds a new vehicle and stores in current instance's memory
        private static Boolean AddNewVehicle(Vehicle vehicle)
        {
            try
            {
                //vehicle id is nothing but the current size of list plus 1
                vehicle.VehicleId = vehicles.Count + 1;
                vehicles.Add(vehicle);
                return true;
            }
            catch
            {
                throw;
            }
        }

        //returns the current instance's list of vehicles
        public static List<Vehicle> GetAllVehicles()
        {
            return vehicles;
        }


        //Function to deserialize JSON object and extract vehicle details
        public static void ExtractVehicleDetails(JsonElement VehicleJson)
        {
            string vehicleType = VehicleJson.GetProperty("type").ToString();
            string vehicleMake = VehicleJson.GetProperty("make").ToString();
            string vehicleModel = VehicleJson.GetProperty("model").ToString();
            string engine = VehicleJson.GetProperty("engine").ToString();
            int numOfDoors = int.Parse(VehicleJson.GetProperty("numOfDoors").ToString());
            int numOfWheels = int.Parse(VehicleJson.GetProperty("numOfWheels").ToString());
            string bodyType = VehicleJson.GetProperty("bodyType").ToString();

            Vehicle vehicle;

            //Check for the type of vehicle here and create corresponding object
            //Additional functionality for different types can be added
            if (vehicleType.Equals("car"))
            {
                vehicle = new Car(vehicleMake,
                                  vehicleModel,
                                  engine,
                                  numOfDoors,
                                  numOfWheels,
                                  bodyType);
            }
            else
            {
                throw new Exception("Invalid type of vehicles");
            }

            try
            {
                AddNewVehicle(vehicle);
            }
            catch
            {
                throw;
            }

        }   
    }
}
