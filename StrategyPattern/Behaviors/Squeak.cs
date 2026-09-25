using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Behaviors
{
    internal class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
