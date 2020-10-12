using System;

namespace DesignPatterns.FactoryMethod.Sample
{
    public class Bike : IVehicle
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
        }

    }
}