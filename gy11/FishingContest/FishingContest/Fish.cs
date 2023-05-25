namespace Contest {

    public class Fish {
        protected int _Factor;
        public virtual bool IsBream => true;
        public virtual bool IsCatfish=> true;
        public virtual bool IsCarp=> true;
        public int Factor() => _Factor;
        protected Fish(int f) {_Factor = f;}
    }

    public class Bream : Fish {
        private static Bream? _instance = null;
        private Bream () : base(1) {}

        public static Bream Instance() {
            if (_instance == null)
                _instance = new Bream();
            return _instance;
        }
        public override bool IsBream => true;

    }
    public class Catfish : Fish {
        private static Catfish? _instance = null;
        private Catfish () : base(3) {}

        public static Catfish Instance() {
            if (_instance == null)
                _instance = new Catfish();
            return _instance;
        }
        public override bool IsCatfish => true;
    }
    public class Carp : Fish {
        private static Carp? _instance = null;
        private Carp () : base(2) {}

        public static Carp Instance() {
            if (_instance == null)
                _instance = new Carp();
            return _instance;
        }
        public override bool IsCarp => true;
    }
}