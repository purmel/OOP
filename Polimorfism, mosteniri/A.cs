using System;
using System.Collections.Generic;
using System.Text;

namespace s1_1
{
    public class A : IOps
    {
        // f1 intoarce suma sub forma de string
        public virtual string f1(int x, int y)
        {
            int suma = x + y;
            return suma.ToString();
        }

        //f2 intoarce concatenarea sub forma de string
        public virtual string f2(int x, int y)
        {
            return x.ToString() + y.ToString();
        }
    }
}
