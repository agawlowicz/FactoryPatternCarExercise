using System;
namespace FactoryPatternCarExercise
{
    public class Motorcycle : ICallable
    {
        public Motorcycle()
        {
        }

        public void Build()
        {
            Console.WriteLine("You have a motorcycle!");
        }
    }
}
