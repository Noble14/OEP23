namespace Contest {

    public class Catch {
       public readonly Fisher Fisher;
       public readonly string Time ;
       public readonly double Weight;
       public readonly Fish Fish;
       public readonly Contest Contest;

       public Catch(double tomeg, Fisher fisher, Fish fish, Contest contest)
       {
            Fisher = fisher;
            Weight = tomeg;
            Time = DateTime.Today.ToString();
            Fish = fish;
            this.Contest = contest;
       }
       public double Value(){
        return Fish.Factor() * this.Weight;
       }
    } 
}