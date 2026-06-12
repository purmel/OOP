using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace s1_1
{
    public class Date : IComparable
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

            bool esteBisect = (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);

            if (esteBisect)
                zileInLuna[2] = 29;

            if (zi > zileInLuna[luna])
            {
                return false;
            }    

            return true;
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
                throw new ArgumentException("Data nu este valida");
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

        public static bool operator <(Date d1, Date d2)
        {
            if (d1.an != d2.an) return d1.an < d2.an;
            if (d1.luna != d2.luna) return d1.luna < d2.luna;
            else return d1.zi < d2.zi;
        }

        public static bool operator >(Date d1, Date d2)
        {
            if (d1.an != d2.an) return d1.an > d2.an;
            if (d1.luna != d2.luna) return d1.luna > d2.luna;
            else return d1.zi > d2.zi;
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
            DateTime first = new DateTime(d1.an, d1.luna, d1.zi);
            DateTime second = new DateTime(d2.an, d2.luna, d2.zi);

            return Math.Abs((first - second).Days);
        }

        public override string ToString()
        {
            return $"{zi}/{luna}/{an}";
        }

        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;

            Date altadata = obj as Date;

            if(altadata != null)
            {
                DateTime acum = new DateTime(this.an, this.luna, this.zi);
                DateTime alta = new DateTime(altadata.an, altadata.luna, altadata.zi);

                return acum.CompareTo(alta);
            }

            else
            {
                throw new ArgumentException("Obiectul nu este de tip Date");
            }
        }
    }
}
