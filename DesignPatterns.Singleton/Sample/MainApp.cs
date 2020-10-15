using System;

namespace DesignPatterns.Singleton.Sample
{
    public class MainApp
    {
        static void RunMain()
        {
            Server.Instance.Show();
            Server.Instance.Show();

            Console.ReadKey();
        }

    }
}