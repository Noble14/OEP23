using Invoice;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int sum = 0;
            Invoice.Infile infile = new("input.txt");
            while (infile.Read(out Invoice.Invoice? invoice))
            {
                if (invoice != null) sum += invoice.Sum;
            }
            Console.WriteLine($"Az osszbevetel: {sum}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("no such file");
        }
    }
}