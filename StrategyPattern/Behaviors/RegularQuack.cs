using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Behaviors
{
    internal class RegularQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("quack");
        }
    }
}
