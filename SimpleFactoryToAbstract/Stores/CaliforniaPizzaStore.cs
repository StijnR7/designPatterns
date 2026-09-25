namespace SimpleFactoryToAbstract
{
    internal class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CaliforniaStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new CaliforniaStyleVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new CaliforniaStyleClamPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new CaliforniaStylePepperoniPizza();
            }

            return pizza;
        }
    }
}
