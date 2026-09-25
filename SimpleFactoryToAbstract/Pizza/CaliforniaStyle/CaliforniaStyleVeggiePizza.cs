namespace SimpleFactoryToAbstract
{
    internal class CaliforniaStyleVeggiePizza : Pizza
    {
        public CaliforniaStyleVeggiePizza()
        {
            name = "California Style Veggie Pizza";
            dough = "Crispy Crust Dough";
            sauce = "Pesto Sauce";
            toppings.Add("Avocado");
        }
    }
}
