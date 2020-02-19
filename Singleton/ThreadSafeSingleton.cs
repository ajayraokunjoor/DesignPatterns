namespace Singleton
{
    public sealed class ThreadSafeSingleton
    {
        private static int counter = 0;
        private static readonly object InstanceLock = new object();

        private ThreadSafeSingleton()
        {
            counter++;
            System.Console.WriteLine("Counter value" + counter.ToString());
        }

        private static ThreadSafeSingleton instance = null;

        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                lock(InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                    return instance;
                }
            }
        }

        public void PrintDetails(string message)
        {
            System.Console.WriteLine(message);
        }

    }
}
