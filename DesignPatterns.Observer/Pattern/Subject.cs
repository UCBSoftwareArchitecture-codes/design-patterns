using System.Collections;

namespace DesignPatterns.Observer.Pattern
{
    public abstract class Subject
    {
        private ArrayList _observers = new ArrayList();

        public void Attach(IObserver o)
        {
            _observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            _observers.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver o in _observers)
            {
                o.Update();
            }
        }

    }
}