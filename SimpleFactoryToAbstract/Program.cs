namespace SimpleFactoryToAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYPizzaStore();
            Pizza pizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered " + pizza.Name);
            Console.WriteLine();

            PizzaStore californiaStore = new CaliforniaPizzaStore();
            pizza = californiaStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered " + pizza.Name);
            Console.WriteLine();

            pizza = californiaStore.OrderPizza("pepperoni");
            Console.WriteLine("Joel ordered " + pizza.Name);
            Console.WriteLine();

            pizza = californiaStore.OrderPizza("clam");
            Console.WriteLine("Joel ordered " + pizza.Name);
            Console.WriteLine();

            pizza = californiaStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered " + pizza.Name);
        }
    }
}
