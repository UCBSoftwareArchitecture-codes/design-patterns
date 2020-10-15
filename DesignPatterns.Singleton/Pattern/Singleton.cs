namespace DesignPatterns.Singleton.Pattern
{
    //eager initialization of singleton
    public class Singleton
    {
        private static Singleton _instance = new Singleton();
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}