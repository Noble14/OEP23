using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Parcel
    {
        private int plantTime;
        private Plant? plant = null;

        public Parcel() { }

        public void Plant(Plant plant, int time)
        {
            if (this.plant != null) throw new NotImplementedException();
            this.plant = plant;
            this.plantTime = time;
        }

        public bool CanHarvest(int date)
        {
            return (plant != null && plant.IsZöldség() && date - plantTime == plant.GetEres());
        }
    }
}
