using StrategyPattern.Ducks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();

            Test(mallardDuck);
            Test(redheadDuck);
            Test(decoyDuck);
            Test(rubberDuck);
            Test(robotDuck);
        }

        static void Test(Duck duck)
        {
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            duck.PerformSwim();
            Console.WriteLine();
        }
    }
}
