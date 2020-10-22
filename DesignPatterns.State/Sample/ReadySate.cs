using System;
namespace DesignPatterns.State.Sample
{
    public class ReadySate : IPrinterState
    {
        public void HandleOperation(Printer printerContext)
        {
           Console.WriteLine("Printer is Ready.");
        }
    }
}