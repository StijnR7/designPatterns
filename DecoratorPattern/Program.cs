using DecoratorPattern.Beverages;
using DecoratorPattern.Factory;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory factory = new BeverageFactory();

            foreach (CoffeeType type in Enum.GetValues(typeof(CoffeeType)))
            {
                PrintBeverage(factory.CreateBeverage(type, Size.TALL));
            }

            PrintBeverage(factory.CreateBeverage(CoffeeType.Mocha, Size.GRANDE));
            PrintBeverage(factory.CreateBeverage(CoffeeType.Mocha, Size.VENDI));
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.Size + " " + beverage.GetDescription() + " $" + beverage.cost().ToString("0.00"));
        }
    }
}
