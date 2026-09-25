using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryToAbstract
{
    internal abstract class Pizza
    {
        public string Name { get { return name; } }
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();
        internal void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 200 degrees Celcius");
        }

        internal void Box()
        {
            Console.WriteLine("Placing the Pizza in official PizzaStore box");
        }

        internal virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        internal void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (string p in toppings)
            {
                Console.WriteLine(" "+ p);
            }
        }
    }
}
