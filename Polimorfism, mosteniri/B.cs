using System;
using System.Collections.Generic;
using System.Text;

namespace s1_1
{
    public class B: IOps
    {
        // f1 CMMDC folosind algoritmul lui euclid
        string IOps.f1(int x, int y)
        {
            int a = Math.Abs(x);
            int b = Math.Abs(y);
            while(b!=0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a.ToString();
        }

        //f2 CMMMC cu formula matematica (x * y) / CMMDC
        string IOps.f2(int x, int y)
        {
            int cmmdc = int.Parse(((IOps)this).f1(x, y));

            int cmmmc = (Math.Abs(x) * Math.Abs(y)) / cmmdc;
            return cmmmc.ToString();
        }
    }
}
