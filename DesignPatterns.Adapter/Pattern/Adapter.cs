namespace DesignPatterns.Adapter.Pattern
{
    public class Adapter : Adaptee, ITarget
    {
        public void MethodA()
        {
            MethodB();
        }
    }
}