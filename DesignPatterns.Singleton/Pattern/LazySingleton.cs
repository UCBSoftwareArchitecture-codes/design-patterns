namespace DesignPatterns.Singleton.Pattern
{
    ////lazy initialization of singleton
    public class LazySingleton
    {
        private static LazySingleton _instance = null;

        private LazySingleton() { }

        public static LazySingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LazySingleton();

                return _instance;
            }
        }

    }
}