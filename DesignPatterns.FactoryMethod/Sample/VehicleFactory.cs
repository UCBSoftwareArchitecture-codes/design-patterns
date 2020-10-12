namespace DesignPatterns.FactoryMethod.Sample
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string Vehicle);
        
    }
}