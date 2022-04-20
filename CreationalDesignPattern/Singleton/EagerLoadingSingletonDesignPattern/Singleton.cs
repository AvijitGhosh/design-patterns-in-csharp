namespace CreationalDesignPattern.Singleton.EagerLoadingSingletonDesignPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly Singleton instance = new Singleton();

        public static Singleton GetInstance
        {
            get
            {
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
