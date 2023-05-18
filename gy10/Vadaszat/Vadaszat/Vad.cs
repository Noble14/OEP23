namespace Vadaszat
{
    public class Vad
    {
        protected int Tomeg;
        public bool Him => Nem == "male";
        private string Nem;
        public Vad(int tomeg, string nem)
        {
            Tomeg = tomeg;
            Nem = nem;
        }

        public virtual bool IsElephant() => false;
        public virtual bool IsRhino() => false;
        public virtual bool IsLion() => false;

    }

    public class Lion : Vad
    {
        public Lion(int tomeg, string nem) : base(tomeg, nem)
        {

        }
        public override bool IsLion() => true;

    }

    public class Rhino : Vad
    {
        public readonly int Szarv;
        public Rhino(int tomeg, string nem, int szarv) : base(tomeg, nem)
        {
            Szarv = szarv;
        }
        public override bool IsRhino()
        {
            return true;
        }
    }
    public class Elephant : Vad {
        public readonly int Left;
        public readonly int Rigth;
        public Elephant(int t, string n, int l, int r) : base(t,n)
        {
            Left = l;
            Rigth = r;
        }
        public override bool IsElephant()
        {
            return true;
        }
    }

}