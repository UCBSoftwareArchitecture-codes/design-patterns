using System;

namespace DesignPatterns.Singleton.Sample
{
    public class Server
    {
        private static Server _instance = null;
        private static object _syncLock = new object();
        private string _name;
        private string _ip;

        private Server()
        {
            /// Can be load from a config file.
            _name = "Authentication Server";
            _ip = "192.168.1.23";
        }

        public static Server Instance
        {
            get
            {

                lock (_syncLock)
                {
                    if (_instance == null)
                        _instance = new Server();

                    return _instance;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", _ip, _name);
        }


    }
}