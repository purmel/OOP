using System;
using System.Collections.Generic;
using System.Text;

namespace s1_1
{
    public class Complex : IComparable<Complex>
    {
        private double reala;
        private double imaginara;

        public Complex()
        {
            reala = 0;
            imaginara = 0;
        }

        public Complex(double r, double i)
        {
            reala = r;
            imaginara = i;
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            if (c1 is null && c2 is null) return true;
            if (c1 is null || c2 is null) return false;

            return c1.reala == c2.reala && c1.imaginara == c2.imaginara;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        private double Modul()
        {
            return Math.Sqrt(reala * reala + imaginara * imaginara);
        }

        public static bool operator <(Complex c1, Complex c2)
        {
            return c1.Modul() < c2.Modul();
        }

        public static bool operator >(Complex c1, Complex c2)
        {
            return c1.Modul() > c2.Modul();
        }

        public static bool operator <=(Complex c1, Complex c2)
        {
            return c1 == c2 || c1 < c2;
        }

        public static bool operator >=(Complex c1, Complex c2)
        {
            return c1 == c2 || c1 > c2;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.reala + c2.reala, c1.imaginara + c2.imaginara);
        }

        public override string ToString()
        {
            if (imaginara < 0) return $"{reala} - {Math.Abs(imaginara)}i";

            return $"{reala} + {imaginara}i";
        }

        public int CompareTo(Complex other)
        {
            if (other == null) return 1;

            if (this.Modul() < other.Modul()) return -1;
            if (this.Modul() > other.Modul()) return 1;

            return 0;
        }
    }
}
