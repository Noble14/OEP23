using System;
namespace Garden
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Garden garden = new(5);
            Gardener gardener = new(garden);

            gardener.Plant(1, Potatoe.Instance(), 3);
            gardener.Plant(2, Pea.Instance(), 3);
            gardener.Plant(4, Pea.Instance(), 3);

            Console.Write("A betakarithato parcellak azonositoi: ");
            foreach (int i in gardener.garden.CanHarvest(6))
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}