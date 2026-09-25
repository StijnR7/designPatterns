using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Behaviors
{
    internal class Float : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm floating!");
        }
    }
}
