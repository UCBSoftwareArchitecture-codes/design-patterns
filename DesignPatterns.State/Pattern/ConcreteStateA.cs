using System;

namespace DesignPatterns.State.Pattern
{
    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handle called from ConcreteStateA");
            context.State = new ConcreteStateB();
        }

    }
}