using System;

namespace Singleton
{
    public class LazySingleton
    {
        public static int counter = 0;
        private static readonly LazySingleton singleInstance = new LazySingleton();

        private LazySingleton()
        {
            counter++;
            Console.WriteLine("Counter Value" + counter.ToString());
        }

        public static LazySingleton GetInstance
        {
            get
            {
                return singleInstance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
