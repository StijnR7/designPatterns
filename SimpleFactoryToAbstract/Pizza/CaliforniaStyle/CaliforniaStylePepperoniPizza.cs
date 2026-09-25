namespace SimpleFactoryToAbstract
{
    internal class CaliforniaStylePepperoniPizza : Pizza
    {
        public CaliforniaStylePepperoniPizza()
        {
            name = "California Style Pepperoni Pizza";
            dough = "Crispy Crust Dough";
            sauce = "Pesto Sauce";
            toppings.Add("Sliced Pepperoni");
        }
    }
}
