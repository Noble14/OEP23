namespace Contest
{
    public class Organization
    {
        public List<Contest> Contests { get; private set; }
        public List<Fisher> Fishers { get; private set; }
        public Organization()
        {
            Fishers = new();
            Contests = new();
        }

        public void Join(string Name) {
            
            Fishers.Add(new Fisher(Name));
        }
        public Contest Organize(string contestname) {
            Contest c = new Contest(contestname, "", this);
            Contests.Add(c);
            return c;
        }

        public Fisher? Member(string nev) {
            Fisher? fisher = null;
            foreach (Fisher f in Fishers) {
                if (f.Name == nev)
                    return f;
            }

            return fisher;
        }

    }

}