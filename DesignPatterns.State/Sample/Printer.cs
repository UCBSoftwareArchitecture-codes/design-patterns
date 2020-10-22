using System;
namespace DesignPatterns.State.Sample
{
    public class Printer
    {
        private IPrinterState _printerState;

        public Printer()
        {
            _printerState = new ReadySate();
        }

        public IPrinterState PrinterState
        {
            get
            {
                return _printerState;
            }
            set
            {
                _printerState=value;
            }
        }

      

        public void Print()
        {
            Console.WriteLine("Printing process Begins.");
            _printerState= new PrintStartState();
            _printerState.HandleOperation(this);
            
        }
    }
}