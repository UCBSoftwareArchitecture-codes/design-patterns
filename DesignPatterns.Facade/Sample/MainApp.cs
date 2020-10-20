using System;

namespace DesignPatterns.Facade.Sample
{
    public class MainApp
    {
        static void RunMain(string[] args)
        {
            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();

        }

    }
}