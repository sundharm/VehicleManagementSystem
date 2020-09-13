/*
 * 
 * A class for the Car vehicle type, which inherits the
 * vehicle abstract class, plus has it's own specifications.
 *
 */


namespace VehicleManagementSystem.Models
{
    public class Car : Vehicle
    {
        public string Engine { get; set; }

        public int NumOfDoors { get; set; }

        public int NumOfWheels { get; set; }

        public string BodyType { get; set; }

        //assigns the vehicle class with the "type" of vehicle
        public Car(
            string VehicleType,
            string Make,
            string Model,
            string Engine,
            int NumOfDoors,
            int numOfWheels,
            string bodyType) : base(VehicleType, Make, Model)
        {
            this.NumOfDoors = NumOfDoors;
            this.NumOfWheels = numOfWheels;
            this.BodyType = bodyType;
            this.Engine = Engine;
        }
    }
}
