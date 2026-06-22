using System;
using System.Collections.Generic;
using System.Text;

namespace s1_1
{
    public class Time : IComparable<Time>
    {
        private int ora;
        private int minutul;
        private int secunda;

        private bool EsteValid(int o, int m, int s)
        {
            if (o < 0 || o > 23 || m < 0 || m > 59 || s < 0 || s > 59)
                return false;

            else return true;
        }

        public Time()
        {
            ora = 0;
            minutul = 0;
            secunda = 0;
        }

        public Time(int o, int m, int s)
        {
            if (EsteValid(o, m, s))
            {
                ora = o;
                minutul = m;
                secunda = s;
            }
            else
            {
                ora = 0;
                minutul = 0;
                secunda = 0;
            }
        }

        public static bool operator ==(Time t1, Time t2)
        {
            if (t1 is null && t2 is null) return true;
            if (t1 is null || t2 is null) return false;

            return t1.ora == t2.ora && t1.minutul == t2.minutul && t1.secunda == t2.secunda;
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        private int TotalSecunde()
        {
            return ora * 3600 + minutul * 60 + secunda;
        }

        public static bool operator <(Time t1, Time t2)
        {
            return t1.TotalSecunde() < t2.TotalSecunde();
        }

        public static bool operator >(Time t1, Time t2)
        {
            return t1.TotalSecunde() > t2.TotalSecunde();
        }

        public static bool operator <=(Time t1, Time t2)
        {
            return (t1 < t2 || t1 == t2);
        }

        public static bool operator >=(Time t1, Time t2)
        {
            return (t1 > t2 || t1 == t2); 
        }

        public static Time operator +(Time t1, Time t2)
        {
            int totalSecunde = t1.TotalSecunde() + t2.TotalSecunde();

            totalSecunde = totalSecunde % (24 * 3600);

            int orele = totalSecunde / 3600;
            totalSecunde = totalSecunde % 3600;

            int minutele = totalSecunde / 60;
            int secundele = totalSecunde % 60;

            return new Time(orele, minutele, secundele);
            /*int totalsecunde = t1.secunda + t2.secunda;
            int s = totalsecunde % 60;
            int extraMinute = totalsecunde / 60;

            int totalminute = t1.minutul + t2.minutul + extraMinute;
            int m = totalminute % 60;
            int extraOre = totalminute / 60;

            int totalore = t1.ora + t2.ora + extraOre;
            int o = totalore % 24;

            return new Time(o, m, s);*/

            //sau 
            /*int totalsecunde = t1.secunda + t2.secunda;
            int totalminute = t1.minutul + t2.minutul;
            int totalore = t1.ora + t2.ora;

            if (totalsecunde > 59)
            {
                totalminute += 1;
                totalsecunde = totalsecunde - 60; // Scădem un minut complet
            }

            if (totalminute > 59)
            {
                totalore += 1;
                totalminute = totalminute - 60; // Scădem o oră completă
            }

            if (totalore > 23)
            {
                totalore = totalore - 24; // Scădem o zi completă
            }

            // Cuvântul "new" este obligatoriu la crearea unui obiect nou
            return new Time(totalore, totalminute, totalsecunde);*/
        }

        public override string ToString()
        {
            return $"{ora:D2}:{minutul:D2}:{secunda:D2}";
        }

        public int CompareTo(Time other)
        {
            if (other == null) return 1;

            if (this > other) return 1;
            if (this < other) return -1;
            return 0;
        }
    }
}
