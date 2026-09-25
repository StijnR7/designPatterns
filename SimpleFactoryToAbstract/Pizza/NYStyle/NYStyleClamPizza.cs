namespace SimpleFactoryToAbstract
{
    internal class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            name = "NY Style Sauce and Clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }
}