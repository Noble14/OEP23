using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrQueue
{
    public class Element
    {
        public int Prioritas;
        public string Value;

        public Element(int pr, string val)
        {
            Prioritas = pr;
            Value = val;
        }
    }
    public class PrQueue
    {
        List<Element> Elements = new ();
        public class NoElementsExeption : Exception { }

        public PrQueue()
        {
            
        }

        public void SetEmpty()
        {
            Elements.Clear();
        }
        public bool IsEmpty()
        {
            return Elements.Count == 0;
        }
        public void Add(Element e)
        {
            Elements.Add(e);
        }
        private int GetMaxIndex()
        {
            int maxPr = Elements[0].Prioritas;
            int index = 0;
            for (int i = 0; i < Elements.Count; i++)
            {
                if (maxPr < Elements[i].Prioritas)
                {
                    maxPr = Elements[i].Prioritas;
                    index = i;
                }
            }
            return index;
        }
        public Element GetMax()
        {
            if (Elements.Count == 0)
                throw new NoElementsExeption();
            return Elements[GetMaxIndex()];
        }
        public Element RemMax()
        {
            if (Elements.Count == 0)
                throw new NoElementsExeption();
            Element max = Elements[GetMaxIndex()];
            Elements.RemoveAt(GetMaxIndex());
            return max;
            //return Elements[GetMaxIndex()];
        }
    }
}
