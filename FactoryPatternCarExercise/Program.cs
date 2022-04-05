using System;

namespace FactoryPatternCarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue;
            int tireCount;

            Console.WriteLine("How many tires are on your vehicle?");

            do
            {
                isTrue = int.TryParse(Console.ReadLine(), out tireCount);
            } while (!isTrue);

            ICallable vehicle = VehicleFactory.GetVehicle(tireCount);
            vehicle.Build();
        }
    }
}
