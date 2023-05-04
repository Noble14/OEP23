using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Garden
    {
        List<Parcel> parcels = new List<Parcel>();
        public Garden(int n)
        {
            for (int i = 0; i < n; i++)
            {
                parcels.Add(new Parcel());
            }
        }
        public List<int> CanHarvest(int month)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < parcels.Count; i++)
            {
                if (parcels[i].CanHarvest(month))
                    result.Add(i);
            }
            return result;
        }

        public void Plant(int index, Plant plant, int month)
        {

            if (parcels.Count < index || index < 1 ) throw new NotImplementedException();
            parcels[index].Plant(plant, month);
        }

    }
}
