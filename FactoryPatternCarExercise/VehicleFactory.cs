using System;
namespace FactoryPatternCarExercise
{
    static class VehicleFactory
    {
        public static ICallable GetVehicle(int tireCount)
        {
            switch (tireCount)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                default:
                    return new UnknownVehicle();
            }
        }
    }
}
