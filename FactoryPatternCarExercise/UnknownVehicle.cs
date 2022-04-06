using System;
namespace FactoryPatternCarExercise
{
    public class UnknownVehicle : IVehicle
    {
        public UnknownVehicle()
        {
            Console.WriteLine("I don't know what type of car this is.");
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving!");
        }
    }
}
