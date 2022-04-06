using System;
namespace FactoryPatternCarExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("Building a new motorcycle!");
        }

        public void Drive()
        {
            Console.WriteLine("You are riding a motorcycle!");

            Console.WriteLine($"{GetType().Name} is now moving!");
        }
    }
}
