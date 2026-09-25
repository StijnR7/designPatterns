using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern.Behaviors
{
    internal class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying using my wings!");
        }
    }
}
