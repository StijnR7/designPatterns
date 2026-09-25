using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();

        protected double SizePrice(double price)
        {
            if (Size == Size.GRANDE)
            {
                return price + 0.05;
            }
            if (Size == Size.VENDI)
            {
                return price + 0.10;
            }
            return price;
        }
    }
}
