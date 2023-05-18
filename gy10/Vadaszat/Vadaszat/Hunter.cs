using TextFile;
namespace Vadaszat
{

    public class Trophie
    {
        public readonly string Hely;
        public readonly string Datum;
        public readonly Vad Zsakmany;

        public Trophie(string hely, string date, Vad zs)
        {
            Hely = hely;
            Datum = date;
            Zsakmany = zs;
        }

    }

    public class Hunter
    {

        public List<Trophie> Trophies { get; private set; }
        public int Kor { get; private set; }
        public string Nev { get; private set; }
        public Hunter(string nev, int kor)
        {
            Kor = kor;
            Nev = nev;
            Trophies = new List<Trophie>();
        }

        public void Read(string input)
        {
            TextFileReader reader = new TextFileReader(input);

            while (reader.ReadLine(out string line))
            {

                string[] tokens = line.Split(new char[] {'\t', ' '}, StringSplitOptions.RemoveEmptyEntries);
                // Trophie? tr = null;
                Vad? v = null;
                switch (tokens[2])
                {
                    case "lion":
                        v = new Lion(int.Parse(tokens[3]), tokens[4]);
                        break;
                    case "rhino":
                        v = new Rhino(int.Parse(tokens[3]), tokens[4], int.Parse(tokens[5]));
                        break;
                    case "elephant":
                        v = new Elephant(int.Parse(tokens[3]), tokens[4], int.Parse(tokens[5]), int.Parse(tokens[6]));
                        break;
                    default:
                        throw new NotImplementedException();
                }
                Trophies.Add(new Trophie(tokens[0],tokens[1], v));


            }



        }

        public bool MaxHornWeigthRate(out double weigth)
        {
            bool l = false;
            weigth = 0;
            foreach (Trophie trophie in Trophies)
            {
                Vad v = trophie.Zsakmany;
                if (!v.IsRhino()) continue;
                Rhino rhino = (Rhino)v;
                if (!l)
                {
                    l = true;
                    weigth = rhino.Szarv;
                }
                else
                {
                    if (weigth < rhino.Szarv)
                        weigth = rhino.Szarv;
                }

            }

            return l;
        }

        public int CountMaleLions()
        {
            int db = 0;
            foreach (Trophie trophie in Trophies)
            {
                Vad v = trophie.Zsakmany;
                if (v.IsLion() && v.Him)
                    db++;
            }

            return db;
        }

        public bool SearchEqualTusks()
        {
            foreach (Trophie trophie in Trophies)
            {
                Vad v = trophie.Zsakmany;
                if (v.IsElephant() && ((Elephant)v).Left == ((Elephant)v).Rigth)
                    return true;
                // if (trophie is Elephant elephant) {
                //     elephant.Left
                // }
                // if (trophie.Zsakmany is Elephant ) {
                //    (trophie.Zsakmany as Elephant).
                // }
            }
            return false;
        }
    }



}