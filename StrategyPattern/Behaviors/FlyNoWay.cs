using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern.Behaviors
{
    internal class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
