using System;
using System.Collections.Generic;
using System.Text;

namespace s1_1.Polimorfism__mosteniri
{
    public class D : A
    {
        private int SumaCifrelor(int n)
        {
            int suma = 0;
            n = Math.Abs(n);
            while(n > 0)
            {
                suma += n % 10;
                n /= 10;
            }
            return suma;
        }

        public override string f1(int x, int y)
        {
            int total = SumaCifrelor(x) + SumaCifrelor(y);
            return total.ToString();
        }

        private int NrDivizoriProprii(int n)
        {
            int count = 0;
            n = Math.Abs(n);
            for(int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) count++;
            }
            return count;
        }

        public override string f2(int x, int y)
        {
            if (NrDivizoriProprii(x) > NrDivizoriProprii(y))
                return x.ToString();

            else return y.ToString();
        }
    }
}
