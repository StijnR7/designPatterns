using System.Security.Claims;

namespace SimpleFactoryToAbstract
{
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new NYStyleVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new NYStyleClamPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new NYStylePepperoniPizza();
            }

            return pizza;
        }
    }
}