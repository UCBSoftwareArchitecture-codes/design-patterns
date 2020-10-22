using System;

namespace DesignPatterns.State.Sample
{
    public class PrintingState : IPrinterState
    {
        public void HandleOperation(Printer printerContext)
        {
            Console.WriteLine("{0}: Printer is printing", nameof(PrintingState));
            printerContext.PrinterState = new PrintEndState();
            printerContext.PrinterState.HandleOperation(printerContext);
        }
    }
}