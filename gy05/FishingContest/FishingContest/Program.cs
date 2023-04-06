using FishingContest;

internal class Program
{
    private static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

		try
		{
            bool l = false;
            Infile infile = new("input.txt");
            while (infile.Read(out Fisher fisher) && !l)
            {
                if (fisher.Ponty > 10)
                {
                    Console.WriteLine(fisher.Name);
                    l = true;
                }
            }
            if (!l )
                Console.WriteLine("nem volt ilyen");
        }
		catch (FileNotFoundException)
		{
            Console.WriteLine("nincs ilyen file");
        }
    }
}