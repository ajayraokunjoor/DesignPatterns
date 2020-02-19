using System;

namespace Singleton
{

    public class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Singleton Invoked :" + counter);
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public class DerivedSingleton : Singleton
        {
            public DerivedSingleton()
            {
                Console.WriteLine("DerivedSingleton Invoked");
            }
        }

    }
}
