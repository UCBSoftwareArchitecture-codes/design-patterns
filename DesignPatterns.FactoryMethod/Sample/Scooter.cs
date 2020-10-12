using System;

namespace DesignPatterns.FactoryMethod.Sample
{
    public class Scooter : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }

    }
}