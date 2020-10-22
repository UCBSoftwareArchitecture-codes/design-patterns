namespace DesignPatterns.State.Sample
{
    public interface IPrinterState
    {
         void HandleOperation(Printer printerContext);
    }
}