using TextFile;


namespace Contest
{
    public partial class Program
    {
        private static void Main(string[] args)
        {
            Organization org = new();
            try
            {
                TextFileReader reader = new("./input/contests.txt");

                reader.ReadLine(out string line);
                char[] separators = new char[] { ' ', '\t' };
                string[] tokens = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < tokens.Length; ++i)
                {
                    org.Join(tokens[i]);    // horgász beléptetése
                }

                while (reader.ReadString(out string filename))
                {
                    TextFileReader reader1 = new(filename);

                    reader1.ReadLine(out string contestname);

                    Contest contest = org.Organize(contestname);              // verseny kiírása

                    while (reader1.ReadString(out string fishername))
                    {    // verseny eseményei
                        reader1.ReadString(out string fishname);
                        reader1.ReadDouble(out double weight);

                        Fisher fisher = org.Member(fishername);
                        if (null == fisher)
                        {
                            Console.WriteLine($"{fishername} versenyezne, de nem tag");
                            // beléptethetnénk: h.belep(horgasznev);
                            // majd regisztrálnánánk: lásd else ág
                        }
                        else
                        {
                            contest.SignUp(fishername);

                            if (fishname == "keszeg") fisher.Catch(Bream.Instance(), weight, contest);
                            else if (fishname == "ponty") fisher.Catch(Carp.Instance(), weight, contest);
                            else if (fishname == "harcsa") fisher.Catch(Catfish.Instance(), weight, contest);
                        }
                    }
                }

                if (org.BestContest(out Contest contest1)) Console.WriteLine($"A legjobb verseny: {contest1.Place}");
                else Console.WriteLine("Nincs olyan verseny, ahol mindenki fogott harcsat.");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Hibás fájlnév");
            }
        }
    }
}
