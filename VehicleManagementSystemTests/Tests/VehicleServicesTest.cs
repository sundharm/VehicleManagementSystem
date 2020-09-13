using System;
using Xunit;
using VehicleManagementSystem.Services;

namespace VehicleManagementSystemTests.Tests
{ 
    public class VehicleServicesTest
    {
        //Test adding a new car functionality
        [Fact]
        public void TestAddCar()
        {
            int sizeBeforeAddCar = VehicleServices.GetAllCars().Count;

            VehicleServices.AddCar("car", "BMW", "3S", "v6", 4, 4, "Sedan");


            int sizeAfterAddCar = VehicleServices.GetAllCars().Count;

            Assert.Equal(sizeBeforeAddCar + 1, sizeAfterAddCar);


        }

        //Test if an exception is being thrown when trying to add a different type of vehicle
        [Fact]
        public void TestAddCarInvalidType()
        {

            bool isExceptionThrown = false;

            try
            {
                VehicleServices.AddCar("bike", "Ducati", "Panigale", "v2", 0, 2, "Sports");
            }
            catch
            {
                isExceptionThrown = true;
            }

           Assert.True(isExceptionThrown);

        }

    }
}
