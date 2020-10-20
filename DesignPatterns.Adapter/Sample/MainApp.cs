using System;

namespace DesignPatterns.Adapter.Sample
{
    public class MainApp
    {
        static void RunMain(string[] args)
        {
            ITarget Itarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
            client.ShowEmployeeList();

            Console.ReadKey();

        }

    }
}