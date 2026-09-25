using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Behaviors
{
    internal class Sink : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm sinking!");
        }
    }
}
