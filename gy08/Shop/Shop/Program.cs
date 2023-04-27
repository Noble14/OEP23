namespace Shop
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer c1 = new Customer("inputs/customer.txt");
            Shop store = new Shop("inputs/food.txt", "inputs/tech.txt");
            c1.Shop(store);
        }
    }
}