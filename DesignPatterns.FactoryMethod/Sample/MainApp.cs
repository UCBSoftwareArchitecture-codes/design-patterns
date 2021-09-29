using System;

namespace DesignPatterns.FactoryMethod.Sample
{
    public class MainApp
    {
        static void RunMain(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IVehicle scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);
            Scooter s = scooter as Scooter;

            IVehicle bike = factory.GetVehicle("Bike");
            bike.Drive(20);
            Bike b = bike as Bike;

            Console.ReadKey();

        }

    }
}