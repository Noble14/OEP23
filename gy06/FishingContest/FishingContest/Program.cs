using FishingContest;

internal class Program
{
    private static void Main(string[] args)
    {

        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");        
        Console.WriteLine("Hello, World!");
        InFile inf = new InFile("input.txt");
        while (inf.ReadFisher(out Fisher f))
        {
            if (f == null) continue;
            if (f.harcsak() >= 2)
                Console.WriteLine(f.Name);
        }

        //Fisher.Catch
    }
}