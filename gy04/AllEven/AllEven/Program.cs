using TextFile;

internal class Program
{
    private static void Main(string[] args)
    {
        TextFileReader reader = new TextFileReader("input.txt");
        bool l = true;
        while (l && reader.ReadInt(out int num))
        {
            if (num % 2 != 0) l = false;
        }
        Console.WriteLine(l ? "Minden szám páros" : "Nem minden szám páros");
    }
}