using System;
namespace FactoryPatternCarExercise
{
    public class Car : ICallable
    {
        public Car()
        {
        }

        public void Build()
        {
            Console.WriteLine("You have a car!");
        }
    }
}
