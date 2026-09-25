namespace SimpleFactoryToAbstract
{
    internal class CaliforniaStyleCheesePizza : Pizza
    {
        public CaliforniaStyleCheesePizza()
        {
            name = "California Style Cheese Pizza";
            dough = "Crispy Crust Dough";
            sauce = "Pesto Sauce";
            toppings.Add("Goat Cheese");
        }
    }
}
