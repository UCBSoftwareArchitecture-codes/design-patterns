namespace DesignPatterns.Singleton.Pattern
{
    ////Thread-safe (Double-checked Locking) initialization of singleton
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance = null;
        private ThreadSafeSingleton() { }
        private static object _lockThis = new object();
        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (_lockThis)
                {
                    if (_instance == null)
                        _instance = new ThreadSafeSingleton();
                    return _instance;
                }
            }
        }
    }
}