namespace DesignPatterns.Adapter.Pattern
{
    public class Client
    {
        private ITarget _target;

        public Client(ITarget target)
        {
            this._target = target;
        }

        public void MakeRequest()
        {
            _target.MethodA();
        }
    }
}