using System;

namespace rational
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            try
            {
                Rational r1 = new Rational(1, 2);
                Rational r2 = new Rational(3, 4);

                //r1.Add(r2);
                //Rational.Add(r1, r2);
                Rational res = r1 + r2;
                Console.WriteLine(res);
            }
            catch (Rational.ZeroDivisionException)
            {

                Console.WriteLine("Nulla az osztóban");
            }

            Console.ReadKey();
        }
    }
}
