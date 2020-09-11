/*
 * 
 * An abstract vehicle class with the features common to 
 * all vehicles. Any sub category of vehicle (car,bike) can
 * simply inherit this class along with their category
 * specific features.
 * 
 */

namespace VehicleManagementSystem.Models
{
    public abstract class Vehicle
    {
        public int VehicleId { get; set; }

        public string VehicleType { get; set; }

        public string VehicleMake { get; set; }

        public string VehicleModel { get; set; }

        protected Vehicle(string VehicleType, string VehicleMake, string VehicleModel)
        {
            this.VehicleType = VehicleType;
            this.VehicleMake = VehicleMake;
            this.VehicleModel = VehicleModel;
        }
    }
}
