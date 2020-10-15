using System;

namespace DesignPatterns.Observer.Pattern
{
    public class ConcreteObserverB : IObserver
    {
        private ConcreteSubject _subject;

        public ConcreteObserverB(ConcreteSubject subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            string subjectState = _subject.State;
            Console.WriteLine("From Observer B:"+ subjectState);
        }

    }
}