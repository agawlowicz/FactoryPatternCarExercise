using System;
namespace FactoryPatternCarExercise
{
    static class VehicleFactory
    {
        //make method static, return IVehicle type since car, motorcycle, and unkown classes all implement this type
        public static IVehicle GetVehicle(int tireCount)
        {
            switch (tireCount)
            {
                case 2:
                //case "two":  //if tireCount was a string, can have multiple values for same case
                    return new Motorcycle(); //essentially fills in right side of assignment operator
                case 4:
                    return new Car();
                default:
                    return new UnknownVehicle();
            }
        }
    }
}
