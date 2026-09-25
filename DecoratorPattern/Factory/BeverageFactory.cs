using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factory
{
    internal class BeverageFactory
    {
        public Beverage CreateBeverage(CoffeeType type, Size size)
        {
            Beverage beverage = null;

            switch (type)
            {
                case CoffeeType.Espresso:
                    beverage = new Espresso();
                    beverage.Size = size;
                    break;
                case CoffeeType.Doppio:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    break;
                case CoffeeType.Lungo:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Water(beverage);
                    break;
                case CoffeeType.Macchiato:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeType.Corretta:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Liqour(beverage);
                    break;
                case CoffeeType.ConPanna:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Whip(beverage);
                    break;
                case CoffeeType.Cappuccino:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeType.Americano:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Water(beverage);
                    beverage = new Water(beverage);
                    break;
                case CoffeeType.CaffeLatte:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeType.FlatWhite:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    break;
                case CoffeeType.Romana:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Lemon(beverage);
                    break;
                case CoffeeType.Morocchino:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Chocolate(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeType.Mocha:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Chocolate(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;
                case CoffeeType.Bicerin:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new BlackChocolate(beverage);
                    beverage = new WhiteChocolate(beverage);
                    beverage = new Whip(beverage);
                    break;
                case CoffeeType.Breve:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new MilkFoam(beverage);
                    beverage = new HalfMilk(beverage);
                    break;
                case CoffeeType.RafCoffee:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new VanillaSugar(beverage);
                    beverage = new Cream(beverage);
                    break;
                case CoffeeType.MeadRaf:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Honey(beverage);
                    beverage = new Cream(beverage);
                    break;
                case CoffeeType.Galao:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new MilkFoam(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeType.CaffeAffogato:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    beverage = new IceCream(beverage);
                    break;
                case CoffeeType.ViennaCoffee:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    beverage = new Whip(beverage);
                    beverage = new Whip(beverage);
                    break;
                case CoffeeType.Glace:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new IceCream(beverage);
                    break;
                case CoffeeType.ChocolateMilk:
                    beverage = new Chocolate();
                    beverage.Size = size;
                    beverage = new Milk(beverage);
                    beverage = new Milk(beverage);
                    break;
                case CoffeeType.DemiCreme:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Cream(beverage);
                    break;
                case CoffeeType.LatteMacchiato:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new MilkFoam(beverage);
                    break;
                case CoffeeType.Freddo:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Liqour(beverage);
                    beverage = new Ice(beverage);
                    break;
                case CoffeeType.Frappuccino:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Whip(beverage);
                    break;
                case CoffeeType.CaramelFrappuccino:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Ice(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new Cream(beverage);
                    beverage = new Syrup(beverage);
                    break;
                case CoffeeType.Frappe:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new SteamedMilk(beverage);
                    beverage = new SteamedMilk(beverage);
                    beverage = new IceCream(beverage);
                    break;
                case CoffeeType.IrishCoffee:
                    beverage = new Espresso();
                    beverage.Size = size;
                    beverage = new Espresso(beverage);
                    beverage = new Whiskey(beverage);
                    beverage = new Whip(beverage);
                    break;
            }

            return beverage;
        }
    }
}
