using System;

namespace DesignPatterns.State.Pattern
{
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handle called from ConcreteStateB");
            context.State = new ConcreteStateA();
        }

    }
}