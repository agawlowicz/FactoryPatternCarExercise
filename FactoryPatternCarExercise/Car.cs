using System;
namespace FactoryPatternCarExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Building as new Car!");
        }

        public void Drive()
        {
            Console.WriteLine("You are driving a car!");

            //using GetType()
            Console.WriteLine($"{GetType().Name} is now driving!");
        }
    }
}
