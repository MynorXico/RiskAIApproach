using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAI
{
    public static class MathUtilities
    {
        public static double[] ItemWiseDivision(double[] numerador, double[] denominador)
        {
            if (numerador.Length != denominador.Length)
                throw new Exception("v and w size has to be the same");

            double[] result = new double[numerador.Length];

            for(int i = 0; i < numerador.Length; i++)
            {
                result[i] = numerador[i] / denominador[i];
            }
            return result;
        }


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

        public static double SigmoidFnc(double x)
        {
            return (double) 1 / (1+Math.Exp(-x));
        }

        public static double SigmoidDerivative(double x)
        {
            return x * (1 - x);
        }

        public static double[] StringToDouble(string[] s)
        {
            List<double> ResultList = new List<double>();
            for(int i = 0; i < s.Length; i++)
            {
                ResultList.Add(double.Parse(s[i]));
            }
            return ResultList.ToArray();
        }
    }
}
