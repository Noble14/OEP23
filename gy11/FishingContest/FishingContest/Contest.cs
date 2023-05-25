namespace Contest {

public class Contest {
    public readonly Organization Org;
    public readonly String Place;
    public readonly String Start;
    public List<Fisher> Participants {get; private set;}
    public Contest(string Name, string kezdes, Organization org)
    {
        this.Place = Name;
        Org = org;
        Start = kezdes;
        Participants = new();
    }

    public void SignUp(string name) {
        Fisher? fisher = Org.Member(name);
        if (!Participants.Contains(fisher!))
            Participants.Add(fisher!);
    }
    public double SumValue(){
        double sum = 0; 
        foreach (Fisher fisher in Participants)
        {
            sum+=fisher.SumValue(this);   
        }
        return sum;
    }
    public bool AllCatfish(){
        foreach (Fisher fisher in Participants)
        {
            if (!fisher.CathcedCatfish(this))
                return false;
        }
        return true;
    }
}

}