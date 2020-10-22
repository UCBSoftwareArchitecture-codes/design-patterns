using System;
namespace DesignPatterns.State.Sample
{
    public class PrintStartState : IPrinterState
    {
        public void HandleOperation(Printer printerContext)
        {
            Console.WriteLine("{0}: Printer starts the impresion", nameof(PrintStartState));
            printerContext.PrinterState = new PrintingState();
            printerContext.PrinterState.HandleOperation(printerContext);
            
        }
    }
}