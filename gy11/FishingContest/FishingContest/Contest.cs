namespace Contest {

public class Contest {
    public readonly Organization Org;
    public readonly String Name;
    public readonly String Start;
    public List<Fisher> Participants {get; private set;}
    public Contest(string Name, string kezdes, Organization org)
    {
        this.Name = Name;
        Org = org;
        Start = kezdes;
        Participants = new();
    }

    public void SignUp(string name) {
        Fisher? fisher = Org.Member(name);
        if (!Participants.Contains(fisher!))
            Participants.Add(fisher!);
    }
}

}