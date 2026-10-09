using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class VeryDependentPizzaStore
    {
        public Pizza CreatePizza(string style, string type)
        {
            Pizza pizza = null;
            if(style.Equals("NY"))
            {
                if(type.Equals("cheese"))
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
            }
            else if (style.Equals("Chicago"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new ChicagoStyleCheesePizza();
                }
                else if (type.Equals("veggie"))
                {
                    pizza = new ChicagoStyleVeggiePizza();
                }
                else if (type.Equals("clam"))
                {
                    pizza = new ChicagoStyleClamPizza();
                }
                else if (type.Equals("pepperoni"))
                {
                    pizza = new ChicagoStylePepperoniPizza();
                }
            }
            else if (style.Equals("California"))
            {
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
            }
            else
            {
                Console.WriteLine("Error: Invalid input");
                return null;
            }

            // Antwoord: nu afhankelijk van 12 concrete pizza classes (3 stijlen x 4 types).

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
