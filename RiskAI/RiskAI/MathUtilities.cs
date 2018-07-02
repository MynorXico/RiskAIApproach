using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAI
{
    public static class MathUtilities
    {
        /// <summary>
        /// Sum of the product of v's ith element with w's ith element
        /// </summary>
        /// <param name="v"></param>
        /// <param name="w"></param>
        /// <returns></returns>
        public static double DotProduct(double[] v, double[] w)
        {
            if (v.Length != w.Length)
                throw new Exception("v and w size has to be the same");

            double result = 0;
            for(int i = 0; i < v.Length; i++)
            {
                result += v[i]*w[i];
            }

            return result;
        }

        public static double LogiscticFnc(double x)
        {
            return 1 / (1+Math.Exp(-x));
        }
    }
}
