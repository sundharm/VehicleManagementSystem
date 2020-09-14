using System;
using Xunit;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Services;

namespace VehicleManagementSystemTests.Tests
{ 
    public class VehicleServicesTest
    {
        private readonly IVehicleService _vehicle;
        public VehicleServicesTest()
        {

            _vehicle = new VehicleServices();
        }

        //Test adding a new car functionality
        [Fact]
        public void TestAddCar()
        {
            int sizeBeforeAddCar = _vehicle.GetAllVehicles().Count;

            _vehicle.AddNewVehicle(new Car("car", "BMW", "3S", "v6", 4, 4, "Sedan"));


            int sizeAfterAddCar = _vehicle.GetAllVehicles().Count;

            Assert.Equal(sizeBeforeAddCar + 1, sizeAfterAddCar);
        }

        //Test if an wrong vehicle type is getting added or not
        [Fact]
        public void TestAddCarInvalidType()
        {

            int sizeBeforeAddCar = _vehicle.GetAllVehicles().Count;

            _vehicle.AddNewVehicle(new Car("bike", "BMW", "3S", "v6", 4, 4, "Sedan"));


            int sizeAfterAddCar = _vehicle.GetAllVehicles().Count;

            Assert.Equal(sizeBeforeAddCar, sizeAfterAddCar);
        }

    }
}
