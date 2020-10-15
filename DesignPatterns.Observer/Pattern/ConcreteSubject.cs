namespace DesignPatterns.Observer.Pattern
{
    public class ConcreteSubject : Subject
    {
        private string _state;

        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Notify();
            }
        }
    }
}