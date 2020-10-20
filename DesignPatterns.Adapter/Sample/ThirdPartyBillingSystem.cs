using System;
using System.Collections.Generic;

namespace DesignPatterns.Adapter.Sample
{
    public class ThirdPartyBillingSystem
    {
        private ITarget _employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this._employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            List<string> employee = _employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######### Employee List ##########");
            foreach (var item in employee)
            {
                Console.Write(item);
            }

        }
    }
}