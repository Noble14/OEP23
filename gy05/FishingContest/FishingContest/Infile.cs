using TextFile;

namespace FishingContest
{
    internal class Fisher
    {
        public String Name { get; private set; }
        public double Ponty { get; private set; }
        public Fisher( String name, double sum)
        {
            Name = name;
            Ponty = sum;
        }
    }
    internal class Infile
    {
        private readonly TextFileReader reader;
        public Infile(string input)
        {
            reader = new(input);
        }
        public bool Read(out Fisher fisher)
        {
            fisher = null;
            bool l = reader.ReadLine(out string line);
            if (l)
            {
                string[] tokens = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                double sum = 0;
                for (int i = 1; i < tokens.Length; i=i+4)
                {
                    if (tokens[i+1] == "ponty" && Double.Parse(tokens[i+2]) >= 0.5)
                    {
                        sum = sum + Double.Parse(tokens[i+3]);
                    }
                }
                fisher = new Fisher(tokens[0], sum);
            }
            return l;
        }

    }
}
