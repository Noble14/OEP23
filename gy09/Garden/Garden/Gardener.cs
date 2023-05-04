using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Gardener
    {
        public readonly Garden garden;
        public Gardener(Garden garden)
        {
            this.garden = garden;
        }

        public void Plant(int parcelIndex, Plant plant, int month)
        {
            garden.Plant(parcelIndex, plant, month);
        }


    }
}
