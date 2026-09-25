namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();
            Console.WriteLine("Same instance: " + (boiler1 == boiler2));

            boiler1.fill();
            boiler1.boil();
            Console.WriteLine("Empty: " + boiler2.IsEmpty + ", Boiled: " + boiler2.IsBoiled);
            boiler2.drain();
            Console.WriteLine("Empty: " + boiler1.IsEmpty);

            ChocolateBoiler[] boilers = new ChocolateBoiler[10];
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                int index = i;
                threads[i] = new Thread(() => boilers[index] = ChocolateBoiler.GetInstance());
                threads[i].Start();
            }
            for (int i = 0; i < 10; i++)
            {
                threads[i].Join();
            }

            bool allSame = true;
            for (int i = 0; i < 10; i++)
            {
                if (boilers[i] != boiler1)
                {
                    allSame = false;
                }
            }
            Console.WriteLine("Same instance in all threads: " + allSame);
        }
    }
}
