using TextFile;
internal class Program
{
    struct Cactus
    {
        public string name, country, color;
        public int heigth;
    }

    static bool ReadCactus(TextFileReader reader, out Cactus cactus)
    {
        reader.ReadString(out cactus.name);
        reader.ReadString(out cactus.country);
        reader.ReadString(out cactus.color);
        bool l = reader.ReadInt(out cactus.heigth);
        return l;
    }

    static bool search()
    {
        TextFileReader reader = new("input.txt");
        //bool l = false;
        while (ReadCactus(reader, out Cactus c))
        {
            if (c.color == "piros")
                return true; 
        }
        //Console.WriteLine();
        return false;
    }
    static void select()
    {
        TextFileReader reader = new("input.txt");
        using StreamWriter writer1 = new(@".\..\..\..\out1.txt");
        using StreamWriter writer2 = new(@".\..\..\..\out2.txt");

        while (ReadCactus(reader, out Cactus c))
        {
            if (c.color == "piros")
                writer1.WriteLine(c.name);
            if (c.country == "mexico")
                writer2.WriteLine(c.name);
        }
    }
    static void CondMax()
    {
        TextFileReader reader = new("input.txt");
        bool l = false;
        Cactus max =new();
        while (ReadCactus(reader, out Cactus c))
        {
            if (c.color != "piros") continue;
            if (l)
            {
                if (max.heigth < c.heigth) max = c;
            }
            else
            {
                max = c;
                l = true;
            }
        }
        Console.WriteLine(l ? $"Legnagyobb piros kaktusz {max.name}": "Nincsenek piros kaktuszok");
    }
    
    private static void Main(string[] args)
    {
        bool l = search();
        Console.WriteLine(l ? "Van piros ": "Nincs piros");
        select();
        CondMax();
    }
}