using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public class GreatCommonDivisor
    {
        /// <summary>
        /// Great Common Divisor
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static int GCD(int p, int q)
        {
            if (q == 0)
            {
                return p;
            }
            else
            {
                var r = p % q;
                return GCD(q, r);
            }
        }

    }
}
