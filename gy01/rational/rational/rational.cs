using System;

namespace rational
{
    class Rational
    {
        private int n, d;

        public class ZeroDivisionException : Exception { }

        public Rational(int n, int d)
        {
            if (d == 0) throw new ZeroDivisionException();
            this.d = d;
            this.n = n;
            norm();
        }

        public override string ToString()
        {
            return n + "/" + d;
        }

        private void norm ()
        {
            int greater = Math.Max(n, d);
            int lower = Math.Min(n, d);
            int m = greater % lower;
            while (m != 0)
            {
                greater = lower;
                lower = m;
                m = greater % lower;
            }
            d = d / lower;
            n = n / lower;
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return new Rational(r1.n * r2.d + r2.n * r1.d, r1.d * r2.d);
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            return new Rational(r1.n * r2.d - r2.n * r1.d, r1.d * r2.d);
        }
        public static Rational operator * (Rational r1, Rational r2)
        {
            return new Rational(r1.n * r2.n,r1.d * r2.d);
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            if (r2.n == 0) throw new ZeroDivisionException();
            return new Rational(r1.n * r2.d, r1.d * r2.n);
        }
    }
}
