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
            return CMMDC(x, y).ToString();
        }

        //f2 CMMMC cu formula matematica (x * y) / CMMDC
        string IOps.f2(int x, int y)
        {
            return ((x * y) / CMMDC(x, y)).ToString();
        }

        private int CMMDC(int a, int b)
        {
            while(b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
