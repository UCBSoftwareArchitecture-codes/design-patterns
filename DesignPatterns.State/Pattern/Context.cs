namespace DesignPatterns.State.Pattern
{
    public class Context
    {
        private IState _state;

        public Context(IState newstate)
        {
            _state = newstate;
        }
        public void Request()
        {
            _state.Handle(this);
        }

        public IState State
        {
            get { return _state; }
            set { _state = value; }
        }

    }
}