﻿using System;
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
    public class VehicleServices
    {
        private static List<Vehicle> vehicles = new List<Vehicle>();

        //Adds a new vehicle and stores in current instance's memory
        private static Boolean AddNewVehicle(Vehicle vehicle)
        {
            try
            {
                //vehicle id is nothing but the current size of list plus 1
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
        private static int GetNewID()
        {
            int id = 0;
            if (vehicles.Count > 0)
            {
                id = vehicles[vehicles.Count - 1].VehicleId + 1;
            }
            
            return id;
        }

        //returns the current instance's list of vehicles
        public static List<Vehicle> GetAllCars()
        {
            List<Vehicle> carList = new List<Vehicle>();
            foreach(Vehicle v in vehicles)
            {
                if (v.VehicleType.Equals(Constants.CAR))
                    carList.Add(v);
            }
            return carList;
        }

        //Function to create a new car object to add to vehicle list
        public static void AddCar(string vehicleType,
                                  string vehicleMake,
                                  string vehicleModel,
                                  string engine,
                                  int numOfDoors,
                                  int numOfWheels,
                                  string bodyType)
        {
            Vehicle vehicle;

            //Check for the type of vehicle here and create corresponding object
            //Additional functionality for different types can be added later
            if (vehicleType.Equals(Constants.CAR))
            {
                vehicle = new Car(vehicleType,
                                  vehicleMake,
                                  vehicleModel,
                                  engine,
                                  numOfDoors,
                                  numOfWheels,
                                  bodyType);
            }
            else
            {
                throw new Exception("Invalid type of vehicle");
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
