using System;

namespace DesignPatterns.Observer.Pattern
{
    public class ConcreteObserverBA : IObserver
    {
        private ConcreteSubject _subject;

        public ConcreteObserverBA(ConcreteSubject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            string subjectState = _subject.State;
            Console.WriteLine("From Observer A:"+ subjectState);

        }

    }
}