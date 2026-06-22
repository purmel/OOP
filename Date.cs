using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace s1_1
{
    public class Date : IComparable<Date>
    {
        private int an;
        private int luna;
        private int zi;

        private bool EsteDataValida(int an, int luna, int zi)
        {
            if (an < 1 || luna < 1 || luna > 12 || zi < 1 || zi > 31)
                return false;


            //implementarea pt an bisect, luna februarie
            int[] zileInLuna = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (EsteBisect(an))
                zileInLuna[2] = 29;

            if (zi > zileInLuna[luna])
            {
                return false;
            }    

            return true;
        }

        private bool EsteBisect(int a)
        {
            return (a % 4 == 0 && a % 100 != 0) || (a % 400 == 0);
        }

        public Date()
        {
            an = 1970;
            luna = 1;
            zi = 1;
        }

        public Date(int a, int l, int z)
        {
            if(EsteDataValida(a, l, z))
            {
                an = a;
                luna = l;
                zi = z;
            }

            else
            {
                an = 1970;
                luna = 1;
                zi = 1;
            }
        }

        public static bool operator ==(Date d1, Date d2)
        {
            if (d1 is null && d2 is null) return true;
            if (d1 is null || d2 is null) return false;

            return d1.an == d2.an && d1.luna == d2.luna && d1.zi == d2.zi;
        }

        public static bool operator !=(Date d1, Date d2)
        {
            return !(d1 == d2);
        }

        private int TotalZile()
        {
            int totalZile = 0;

            for(int i = 1; i<= an; i++)
            {
                if (EsteBisect(an))
                    totalZile += 366;

                else totalZile += 365;
            }

            int[] zileInLuna = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if(EsteBisect(an))
            {
                zileInLuna[2] = 29;
            }

            for(int i = 1; i<= luna; i++)
            {
                totalZile += zileInLuna[i];
            }

            totalZile += zi;

            return totalZile;
        }

        public static bool operator <(Date d1, Date d2)
        {
            return d1.TotalZile() < d2.TotalZile();
        }

        public static bool operator >(Date d1, Date d2)
        {
            return d1.TotalZile() > d2.TotalZile();
        }

        public static bool operator <=(Date d1, Date d2)
        {
            return ((d1 < d2) || (d1 == d2));
        }

        public static bool operator >=(Date d1, Date d2)
        {
            return ((d1 > d2) || (d1 == d2));
        }

        public static int operator -(Date d1, Date d2)
        {
            return Math.Abs(d1.TotalZile() - d2.TotalZile());
        }

        public override string ToString()
        {
            return $"{zi:D2}/{luna:D2}/{an}";
        }

        public int CompareTo(Date other)
        {
            if (other is null) return 1;

            if(this.TotalZile() < other.TotalZile()) return -1;

            if (this.TotalZile() > other.TotalZile()) return 1;

            return 0;
        }
    }
}
