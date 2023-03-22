namespace diagonalis
{
    public class Diagonal
    {
        List<double> x = new List<double>();

        public class NotDiagonalElementSettingException : Exception { }

        public class WrgonDimensionException : Exception { }

        public Diagonal(int n)
        {
            for (int i = 0; i < n; i++)
            {
                x.Add(0);
            }
        }
        public Diagonal(List<double> x)
        {
            this.x = x;
        }
        public Diagonal()
        {
            for (int i = 0; i < 3; i++)
            {
                x.Add(1);
            }
        }

        public double GetIJ(int i, int j)
        {
            if (i < 0 || i > x.Count || j < 0 || j > x.Count)
                throw new IndexOutOfRangeException();
            if (i != j)
                return 0;
            return x[i];
        }
        public void SetIJ(int i, int j, double val)
        {
            if (i < 0 || i > x.Count || j < 0 || j > x.Count)
                throw new IndexOutOfRangeException();
            if (i != j)
                throw new NotDiagonalElementSettingException();
            x[i] = val;
        }

        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i > x.Count || j < 0 || j > x.Count)
                    throw new IndexOutOfRangeException();
                if (i != j)
                    return 0;
                return x[i];
            }
            set
            {
                if (i < 0 || i > x.Count || j < 0 || j > x.Count)
                    throw new IndexOutOfRangeException();
                if (i != j)
                    throw new NotDiagonalElementSettingException();
                x[i] = value;
            }
        }

        public static Diagonal operator +(Diagonal a, Diagonal b)
        {
            if (a.x.Count != b.x.Count)
                throw new WrgonDimensionException();
            Diagonal c = new Diagonal(a.x.Count);
            for (int i = 0; i < a.x.Count; i++)
            {
                c[i, i] = a[i, i] + b[i, i];
            }
            return c;
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < x.Count; i++)
            {
                for (int j = 0; j < x.Count; j++)
                {
                    output = output + this[i, j] + " ";
                }
                output = output + "\n";
            }
            return output;
        }
    }
}