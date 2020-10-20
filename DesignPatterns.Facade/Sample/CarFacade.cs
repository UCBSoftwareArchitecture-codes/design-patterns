using System;

namespace DesignPatterns.Facade.Sample
{
    public class CarFacade
    {
        private CarModel _model;
        private CarEngine _engine;
        private CarBody _body;
        private CarAccessories _accessories;

        public CarFacade()
        {
            _model = new CarModel();
            _engine = new CarEngine();
            _body = new CarBody();
            _accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            _model.SetModel();
            _engine.SetEngine();
            _body.SetBody();
            _accessories.SetAccessories();

            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}