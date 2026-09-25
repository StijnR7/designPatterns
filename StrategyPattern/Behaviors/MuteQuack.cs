using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Behaviors
{
    internal class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
