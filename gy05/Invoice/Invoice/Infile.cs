using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace Invoice
{
    internal class Invoice
    {
        //public int MyProperty { get; private set; }

        //private int myVar;

        //string vezeteknev, keresztnev;


        //public string TeljesNev
        //{
        //    get { return vezeteknev + " " + keresztnev; }
        //    set { vezeteknev = value.Split()[0]; }
        //}

        public int Sum { get;private set; }
        public String Customer { get; private set; }

        public Invoice(string v, int s)
        {
            Sum = s;
            Customer = v;
        }

    }

    internal class Infile
    {
        TextFileReader reader;

        public Infile(string infname)
        {
            reader = new TextFileReader(infname);
        }
        public bool Read( out Invoice? invoice)
        {
            invoice = null;
            bool l = reader.ReadLine(out string line );
            //StreamReader sr = new StreamReader(line);
            if (l)
            {
                char[] separator = new char[] { ' ' ,'\t' };
                string[] tokens = line.Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
                int sum = 0;
                for (int i = 1; i < tokens.Length; i=i+2)
                {
                    sum = sum + int.Parse(tokens[i+1]);
                }
                invoice = new Invoice(tokens[0], sum);
            }
            return l;
        }
    }
}
