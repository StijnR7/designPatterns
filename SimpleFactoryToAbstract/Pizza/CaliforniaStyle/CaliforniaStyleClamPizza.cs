namespace SimpleFactoryToAbstract
{
    internal class CaliforniaStyleClamPizza : Pizza
    {
        public CaliforniaStyleClamPizza()
        {
            name = "California Style Clam Pizza";
            dough = "Crispy Crust Dough";
            sauce = "Pesto Sauce";
            toppings.Add("Fresh Clams");
        }
    }
}
