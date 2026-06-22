using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace s1_1
{
    public class Q: IComparable<Q>
    {
        private int numarator;
        private int numitor;

        public Q()
        {
            numarator = 0;
            numitor = 1;
        }

        public Q(int a, int b)
        {
            if(b == 0)
            {
                numarator = 0;
                numitor = 1;
            }
            else
            {
                numarator = a;
                numitor = b;
                Simplifica();
            }
        }

        private int Cmmdc(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while( b != 0 )
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        private void Simplifica()
        {
            int d = Cmmdc(numarator, numitor);

            if (d != 0)
            {
                numarator = numarator / d;
                numitor = numitor / d;
            }

            if(numitor < 0)
            {
                numarator = -numarator;
                numitor = -numitor;
            }
        }

        public override string ToString()
        {
            return $"{numarator} / {numitor}";
        }

        public static Q operator +(Q a, Q b)
        {
            return new Q(a.numarator * b.numitor + a.numitor * b.numarator,
                a.numitor * b.numitor);
        }

        public static Q operator -(Q a, Q b)
        {
            return new Q(a.numarator * b.numitor - a.numitor * b.numarator,
                a.numitor * b.numitor);
        }

        public static Q operator *(Q a, Q b)
        {
            return new Q(a.numarator * b.numarator, a.numitor * b.numitor);
        }

        public static Q operator /(Q a, Q b)
        {
            return new Q(a.numarator * b.numitor, a.numitor * b.numarator);
        }

        public static bool operator ==(Q a, Q b)
        {
            if (a is null && b is null) return true;
            if (a is null || b is null) return false;

            return a.numitor == b.numitor && a.numarator == b.numarator;
        }

        public static bool operator !=(Q a, Q b)
        {
            return !(a == b);
        }

        public static bool operator <(Q a, Q b)
        {
            return a.numarator * b.numitor < a.numitor * b.numarator;
        }

        public static bool operator >(Q a, Q b)
        {
            return a.numarator * b.numitor > a.numitor * b.numarator;
        }

        public static bool operator <=(Q a, Q b)
        {
            return (a == b) || (a < b);
        }

        public static bool operator >=(Q a, Q b)
        {
            return (a == b) || (a > b);
        }

        public int CompareTo(Q other)
        {
            if (other is null) return 1;

            if (this < other) return -1;
            if (this > other) return 1;

            return 0;
        }
    }
}
