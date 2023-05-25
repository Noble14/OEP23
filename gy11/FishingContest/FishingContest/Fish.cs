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

    }
}