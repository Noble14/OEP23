namespace diagonalis
{
    class Program
    {
        static void Main(string[] args)
        {
            Diagonal d1 = new Diagonal();
            d1.SetIJ(0, 0, 1);
            d1[0, 0] = 10;
            Console.WriteLine(d1[0, 0]);
            Console.WriteLine(d1);
        }
    }
}