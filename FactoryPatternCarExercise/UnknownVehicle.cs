using System;
namespace FactoryPatternCarExercise
{
    public class UnknownVehicle : ICallable
    {
        public UnknownVehicle()
        {
        }

        public void Build()
        {
            Console.WriteLine("I don't know what type of vehicle you have.");
        }
    }
}
