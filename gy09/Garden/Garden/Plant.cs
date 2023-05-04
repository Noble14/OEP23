namespace Garden
{
    public class Plant
    {
        protected int érésiidő;

        public int GetEres() => érésiidő;

        protected Plant(int e) { érésiidő = e; }

        virtual public bool IsVirág() => false;
        virtual public bool IsZöldség() => false;
    }

    public class Virág : Plant
    {
        public override bool IsVirág()
        {
            return true;
        }
        protected Virág(int e) : base(e) { }
    }

    public class Zöldség : Plant
    {
        protected Zöldség(int e) : base(e) { }
        public override bool IsZöldség() => true;
    }



    public class Rózsa : Virág
    {
        private static Rózsa? instance = null;
        private Rózsa() : base(8) { }

        public static Rózsa GetInstance()
        {
            if (instance == null) instance = new Rózsa();
            return instance;
        }
    }

    public class Potatoe : Zöldség
    {
        private static Potatoe? instance = null;
        private Potatoe() : base(5) { }
        public static Potatoe Instance()
        {
            if (instance == null) instance = new();
            return instance;
        }
    }
    public class Pea : Zöldség
    {
        private static Pea? instance = null;
        private Pea() : base(3) { }
        public static Pea Instance()
        {
            if (instance ==null) instance = new();
            return instance;
        }
    }

    public class Onion : Zöldség {

        private static Onion? instance =null;
        private Onion() : base (4) {}
        public static Onion Instance() {
            if (instance == null) instance = new();
            return instance;
        }
    }

    public class Tulipe : Virág {
        private static Tulipe? instance = null;
        private Tulipe () : base(7)  {}
        public static Tulipe Instance() {
            if (instance == null) instance = new Tulipe();
            return instance;
        }
    }

    public class Szegfű : Virág {
        private static Szegfű? instance = null;
        private Szegfű() : base(10) {}
        public static Szegfű Instance() {
            if (instance == null) instance = new Szegfű();
            return instance;
        }
    }
}
