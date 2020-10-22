using System;

namespace DesignPatterns.State.Sample
{
    public class PrintEndState : IPrinterState
    {
        public void HandleOperation(Printer printerContext)
        {
            Console.WriteLine("{0}: Print is complete", nameof(PrintEndState));
            printerContext.PrinterState = new ReadySate();
            printerContext.PrinterState.HandleOperation(printerContext);
        }
    }
}