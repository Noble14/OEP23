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
        public void Catch(Fish fish, double w, Contest contest) {
           Catch c = new Catch(w,this,fish,contest); 
           Catches.Add(c);
           
        }

        public double SumValue(Contest contest) {
            double sum = 0;
            foreach (Catch c in Catches){
                if(c.Contest == contest)
                    sum =sum + c.Value();
            }
            return sum;
        }

        public bool CathcedCatfish(Contest contest) {            
            foreach (Catch c in Catches){
                if(c.Contest == contest && c.Fish.IsCatfish)
                    return true;                    
            }
            return false;
        }
    }
}