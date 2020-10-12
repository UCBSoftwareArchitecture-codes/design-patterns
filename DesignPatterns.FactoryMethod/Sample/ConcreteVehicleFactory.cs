using System;

namespace DesignPatterns.FactoryMethod.Sample
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new Exception(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }

    }
}