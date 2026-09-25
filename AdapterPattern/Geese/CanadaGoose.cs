using AdapterPattern.Interfaces;

namespace AdapterPattern.Geese
{
    internal class CanadaGoose : Goose
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying far away");
        }

        public void Honk()
        {
            Console.WriteLine("Honk");
        }
    }
}
