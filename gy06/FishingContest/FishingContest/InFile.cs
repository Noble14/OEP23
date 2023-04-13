using TextFile;

namespace FishingContest
{
    public class Fisher
    {
        public struct Catch
        {
            public double Weight { get; set; }
            public double Length { get; set; }
            public string Date { get; set; }
            public string Name { get; set; }

        }
        public string Name { get; set; }
        public List<Catch> Catches { get; set; }

        public Fisher(string name)
        {
            Name = name;
            Catches = new List<Catch>();
        }
        public int harcsak()
        {
            int c = 0;
            bool second_session = false;
            for (int i = 0; i < Catches.Count; i++)
            {
                if (!second_session && Catches[i].Name == "ponty" && Catches[i].Weight >= 1)
                    second_session = true;
                else
                {
                    if (Catches[i].Name == "harcsa" && Catches[i].Length >= 1)
                        c++;
                }
            }

            return c;
        }
    }
    public class InFile
    {
        TextFileReader reader;

        public InFile(string input)
        {
            reader = new TextFileReader(input);
        }

        public bool ReadFisher(out Fisher fisher)
        {
            fisher = null;
            bool l = reader.ReadLine(out string line);
            if (l)
            {
                string[] tokens = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                fisher = new Fisher(tokens[0]);
                for (int i = 1; i < tokens.Length; i = i + 4)
                {
                    //string[] array = new[] { "er" , "el"};
                    //Fisher.Catch c = new() { Length = 12.3 ,};
                    fisher.Catches.Add(new Fisher.Catch()
                    {
                        Date = tokens[i],
                        Name = tokens[i + 1],
                        Weight = Double.Parse(tokens[i + 2]),
                        Length = Double.Parse(tokens[i + 3]),
                    }  );
                }
            }
            return l;
        }
    }
}
