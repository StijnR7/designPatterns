namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new PizzaStore(new NYPizzaFactory());
            nyStore.OrderPizza("veggie");

            PizzaStore chicagoStore = new PizzaStore(new ChicagoPizzaFactory());
            chicagoStore.OrderPizza("veggie");

            PizzaStore californiaStore = new PizzaStore(new CaliforniaPizzaFactory());
            californiaStore.OrderPizza("veggie");
        }
    }
}
