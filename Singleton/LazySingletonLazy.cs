using System;

namespace Singleton
{
    public class LazySingletonLazy
    {
        public static int counter = 0;
        private static readonly Lazy<LazySingletonLazy> singleInstance = new Lazy<LazySingletonLazy> (() => new LazySingletonLazy())

        private LazySingletonLazy()
        {
            counter++;
            Console.WriteLine("Counter Value" + counter.ToString());
        }

        public static LazySingletonLazy GetInstance
        {
            get
            {
                return singleInstance.Value;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
