namespace Contest {
    public class Fisher {
        public List<Contest> Contests {get; private set;}
        public List<Catch> Catches {get; private set;}
        public readonly string Name;
        public Fisher(string Name)
        {
            Contests = new();
            Catches = new();
            this.Name = Name;
        }
        public void Catch() {
            
        }


    }


}